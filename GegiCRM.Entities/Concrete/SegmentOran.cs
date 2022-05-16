using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GegiCRM.Entities.Concrete
{
    public class SegmentOran : BaseEntity<int>
    {
        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }
        public decimal Oran { get; set; }
        public int CurrencyID { get; set; }
        public int SegmentId { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Segment Segment { get; set; }

    }
}
