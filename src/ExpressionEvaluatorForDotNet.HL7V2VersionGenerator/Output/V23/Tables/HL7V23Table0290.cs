using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0290
    {
        public string Id { get { return @"0290"; } }

        public string TableId { get { return @"0290"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"MIME base64 encoding Characters"; } }

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