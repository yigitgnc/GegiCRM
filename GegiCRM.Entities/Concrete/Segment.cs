using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Segment
    {
        public Segment()
        {
            Customers = new HashSet<Customer>();
            SegmentOrans = new HashSet<SegmentOran>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SegmentOran> SegmentOrans { get; set; }
    }
}
