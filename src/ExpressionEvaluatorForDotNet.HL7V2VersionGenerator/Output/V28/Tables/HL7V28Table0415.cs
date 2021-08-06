using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0415
    {
        public string Id { get { return @"0415"; } }

        public string TableId { get { return @"0415"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"DRG Transfer Type"; } }

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
                            Value = @"E",
                            Description = @"DRG Exempt",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"DRG Non Exempt",
                            Comment = null
                        },
                    };
            } 
        }
    }
}