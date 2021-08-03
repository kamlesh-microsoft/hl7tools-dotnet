using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0836
    {
        public string Id { get { return @"0836"; } }

        public string TableId { get { return @"0836"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Problem Severity"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",
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
