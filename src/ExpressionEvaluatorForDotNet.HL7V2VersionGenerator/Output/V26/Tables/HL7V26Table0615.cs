using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0615
    {
        public string Id { get { return @"0615"; } }

        public string TableId { get { return @"0615"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"User Authentication Credential Type Code"; } }

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
                            Value = @"KERB",
                            Description = @"Kerberos Service Ticket",
                            Comment = @"Structure defined by RFC 1510"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SAML",
                            Description = @"Authenticated User Identity Assertion",
                            Comment = @"XML structure defined by the OASIS Security Assertion Markup Language (SAML) specification"
                        },
                    };
            } 
        }
    }
}
