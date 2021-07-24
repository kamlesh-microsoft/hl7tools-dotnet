﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExpressionEvaluatorForDotNet.HL7V2VersionGenerator.Caristix
{
    public class TableEntryResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}
