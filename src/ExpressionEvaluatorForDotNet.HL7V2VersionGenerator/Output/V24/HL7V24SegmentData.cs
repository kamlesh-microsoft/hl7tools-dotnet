using System;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentData
    {
        public string Id { get; init; }

        public string Name { get; init; }
        
        public string LongName { get; init; }

        public string Sequence { get; init; }

        public string Usage { get; init; }

        public string Rpt { get; init; }

        public bool IsGroup { get; init; }

        public IList<HL7V24SegmentData> Segments { get; init; }
    }
}
