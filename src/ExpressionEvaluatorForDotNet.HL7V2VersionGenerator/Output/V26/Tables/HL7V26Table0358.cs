using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0358
    {
        public string Id { get { return @"0358"; } }

        public string TableId { get { return @"0358"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Practitioner group"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",
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
