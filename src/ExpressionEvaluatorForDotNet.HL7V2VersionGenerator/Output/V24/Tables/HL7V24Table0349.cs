using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0349
    {
        public string Id { get { return @"0349"; } }

        public string TableId { get { return @"0349"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"PSRO/UR approval indicator"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Value = @"1",
                            Description = @"Approved by the PSRO/UR as billed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Automatic approval as billed based on focused review",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Partial approval",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Admission denied",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5",
                            Description = @"Postpayment review applicable",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
