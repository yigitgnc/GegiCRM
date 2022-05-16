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
        public double? Oran { get; set; }
        public int CurrencyID { get; set; }
        public virtual Currency Currency { get; set; }

        public virtual Segment Segment { get; set; }

    }
}
