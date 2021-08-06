using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0294
    {
        public string Id { get { return @"0294"; } }

        public string TableId { get { return @"0294"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Time Selection Criteria Parameter Class Codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"Fri",
                            Description = @"An indicator that Friday is or is not preferred for the day on which the appointment will occur.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Mon",
                            Description = @"An indicator that Monday is or is not preferred for the day on which the appointment will occur.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Prefend",
                            Description = @"An indicator that there is a preferred end time for the appointment request, service or resource.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Prefstart",
                            Description = @"An indicator that there is a preferred start time for the appointment request, service or resource.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Sat",
                            Description = @"An indicator that Saturday is or is not preferred for the day on which the appointment will occur.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Sun",
                            Description = @"An indicator that Sunday is or is not preferred for the day on which the appointment will occur.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Thu",
                            Description = @"An indicator that Thursday is or is not preferred for the day on which the appointment will occur.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Tue",
                            Description = @"An indicator that Tuesday is or is not preferred for the day on which the appointment will occur.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Wed",
                            Description = @"An indicator that Wednesday is or is not preferred for the day on which the appointment will occur.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}