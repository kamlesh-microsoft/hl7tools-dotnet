using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0117
    {
        public string Id { get { return @"0117"; } }

        public string TableId { get { return @"0117"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Account status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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