using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class SegmentOran : BaseEntity<int>
    {
        
        public int? SegmentId { get; set; }
        public decimal? StartPrice { get; set; }
        public decimal? EndPrice { get; set; }
        public double? TlOran { get; set; }
        public double? EuroOran { get; set; }
        public double? UsdOran { get; set; }

        public virtual Segment? Segment { get; set; }
    }
}
