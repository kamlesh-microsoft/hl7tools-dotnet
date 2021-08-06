using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0201
    {
        public string Id { get { return @"0201"; } }

        public string TableId { get { return @"0201"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Telecommunication Use Code"; } }

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
                            Value = @"ASN",
                            Description = @"Answering Service Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BPN",
                            Description = @"Beeper Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EMR",
                            Description = @"Emergency Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NET",
                            Description = @"Network (email) Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORN",
                            Description = @"Other Residence Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRN",
                            Description = @"Primary Residence Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRS",
                            Description = @"Personal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VHN",
                            Description = @"Vacation Home Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WPN",
                            Description = @"Work Number",
                            Comment = null
                        },
                    };
            } 
        }
    }
}