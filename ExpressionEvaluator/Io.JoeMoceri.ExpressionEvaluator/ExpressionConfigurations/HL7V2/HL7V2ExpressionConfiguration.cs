﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Io.JoeMoceri.ExpressionEvaluator
{ 
    public class HL7V2ExpressionConfiguration : ExpressionConfigurationBase
    {
        private readonly IList<ExpressionConfigurationOperator> operators;
        private readonly ExpressionConfigurationOptions options;
        public static string headerSegmentName = "MSH";
        public static string fieldDelimiter = "|";
        public static string componentDelimiter = "^";
        public static string escapeDelimiter = "\\";
        public static string subComponentDelimiter = "&";
        public static string fieldRepetitionDelimiter = "~";
        public static string presentButNull = "\"\"";
        public static IList<string> specialSegmentHeaders;
        public static IDictionary<string, string> encodingConversions;
        internal string endCharacter;
        private HL7V2MessageSegment messageSegment;

        static HL7V2ExpressionConfiguration()
        {
            RebuildEncodingConversions();

            // TODO: I think this should update the delimiters. I need more concrete examples to test against. But this will work for single FHS / BHS segments, I'm not sure for more. I need a test message to see.
            specialSegmentHeaders = new List<string>()
            {
                "MSH",
                "FHS",
                "BHS"
            };
        }

        public static void RebuildEncodingConversions()
        {
            encodingConversions = new Dictionary<string, string>();
            encodingConversions.Add(escapeDelimiter, $"{escapeDelimiter}E{escapeDelimiter}");
            encodingConversions.Add(fieldDelimiter, $"{escapeDelimiter}F{escapeDelimiter}");
            encodingConversions.Add(fieldRepetitionDelimiter, $"{escapeDelimiter}R{escapeDelimiter}");
            encodingConversions.Add(componentDelimiter, $"{escapeDelimiter}S{escapeDelimiter}");
            encodingConversions.Add(subComponentDelimiter, $"{escapeDelimiter}T{escapeDelimiter}");
        }

        public static string EncodeString(string input)
        {
            if (input == null)
            {
                return presentButNull;
            }

            foreach (var encodingConversion in encodingConversions)
            {
                input = input.Replace(encodingConversion.Key, encodingConversion.Value);
            }

            return input;
        }

        public static string DecodeString(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            foreach (var escapeConversion in encodingConversions)
            {
                input = input.Replace(escapeConversion.Value, escapeConversion.Key);
            }

            return input;
        }

        public HL7V2ExpressionConfiguration()
        {
            operators = new List<ExpressionConfigurationOperator>
            {
                CreateExpressionConfigurationOperator(Operator.Addition, OperatorPrecedence.Lower, OperatorType.MathString, fieldDelimiter)
            };

            options = new ExpressionConfigurationOptions
            {
                IgnoreWhitespaceOutsideQuotes = true,
                IgnoreParentheses = true,
                IgnoreQuotesValidation = true
            };

            Setup();

            var additionOperator = MathStringOperators.First(o => o.ExpressionOperator == Operator.Addition);

            additionOperator.SolveOperatorExpression = FieldSolveOperatorExpression;

            ExpressionResult FieldSolveOperatorExpression(ExpressionGroup expGroup)
            {
                bool? endCharacterFound = false;

                // found the end character
                if (endCharacter != null && expGroup.RightOperand.EndsWith(endCharacter))
                {
                    endCharacterFound = true;
                }

                if (messageSegment.Fields.Count == 0)
                {
                    messageSegment.SegmentName = expGroup.LeftOperand;
                    if (specialSegmentHeaders.Any(a => a.Equals(messageSegment.SegmentName)))
                    {
                        messageSegment.AddField(fieldDelimiter);
                    }
                }

                var field = messageSegment.AddField(endCharacterFound.Value ? expGroup.RightOperand.Split(endCharacter)[0] : expGroup.RightOperand);

                if (specialSegmentHeaders.Any(a => a.Equals(expGroup.LeftOperand)))
                {
                    return DefaultExpressionResult;
                }

                // fields contain field repetition
                if (field.Value.Contains(fieldRepetitionDelimiter))
                {
                    var fieldRepetitionSplit = expGroup.RightOperand.Split(fieldRepetitionDelimiter);

                    for (var j = 0; j < fieldRepetitionSplit.Length; j++)
                    {
                        field.AddFieldRepetition(fieldRepetitionSplit[j]);
                    }
                }
                else
                {
                    field.AddFieldRepetition(field.Value);
                }

                for (var k = 0; k < field.FieldRepetitions.Count; k++)
                {
                    var fieldRepetition = field.FieldRepetitions[k];

                    // get the components
                    if (fieldRepetition.Value.Contains(componentDelimiter))
                    {
                        var componentSplit = fieldRepetition.Value.Split(componentDelimiter);

                        for (var i = 0; i < componentSplit.Length; i++)
                        {
                            var component = fieldRepetition.AddComponent(componentSplit[i]);

                            // get the sub components
                            if (component.Value.Contains(subComponentDelimiter))
                            {
                                var subComponentSplit = component.Value.Split(subComponentDelimiter);

                                for (var j = 0; j < subComponentSplit.Length; j++)
                                {
                                    component.AddSubComponent(subComponentSplit[j]);
                                }
                            }
                        }
                    }
                }

                return DefaultExpressionResult;
            }
        }

        internal void Setup()
        {
            messageSegment = new HL7V2MessageSegment();
        }

        public override IList<ExpressionConfigurationOperator> MathStringOperators 
        {
            get
            {
                return operators.Where(o => o.ExpressionOperatorType == OperatorType.MathString).ToList();
            }
        }

        public override IList<ExpressionConfigurationOperator> BooleanOperators
        {
            get
            {
                return operators.Where(o => o.ExpressionOperatorType == OperatorType.Boolean).ToList();
            }
        }

        public override IList<ExpressionConfigurationOperator> Operators => operators;

        public override ExpressionConfigurationOptions Options => options;

        public HL7V2MessageSegment GetHL7V2MessageSegment()
        {
            return messageSegment;
        }
    }
}
