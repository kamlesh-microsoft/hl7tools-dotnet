using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0102
    {
        public string Id { get { return @"0102"; } }

        public string TableId { get { return @"0102"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"DELAYED ACKNOWLEDGMENT TYPE"; } }

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
                            Value = @"D",
                            Description = @"Message Received, stored for later processing",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
