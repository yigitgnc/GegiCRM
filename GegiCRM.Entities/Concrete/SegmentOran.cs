using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class SegmentOran
    {
        public int Id { get; set; }
        public int? SegmentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public decimal? StartPrice { get; set; }
        public decimal? EndPrice { get; set; }
        public double? TlOran { get; set; }
        public double? EuroOran { get; set; }
        public double? UsdOran { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual Segment? Segment { get; set; }
    }
}
