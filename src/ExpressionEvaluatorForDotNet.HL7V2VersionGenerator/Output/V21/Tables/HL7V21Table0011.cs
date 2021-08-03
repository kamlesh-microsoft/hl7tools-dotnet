using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0011
    {
        public string Id { get { return @"0011"; } }

        public string TableId { get { return @"0011"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"CHARGING SYSTEM"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"R",
                            Description = @"System that received and processed the order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"System that sent the order",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
