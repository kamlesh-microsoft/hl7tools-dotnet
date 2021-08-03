using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0544
    {
        public string Id { get { return @"0544"; } }

        public string TableId { get { return @"0544"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Container Condition"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
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
