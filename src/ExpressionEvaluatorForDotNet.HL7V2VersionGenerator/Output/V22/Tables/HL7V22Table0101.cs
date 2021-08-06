using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0101
    {
        public string Id { get { return @"0101"; } }

        public string TableId { get { return @"0101"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"DISPLAY LEVEL"; } }

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
                return null;
            } 
        }
    }
}