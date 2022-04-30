using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Segment : BaseEntity<int>
    {
        public Segment()
        {
            Customers = new HashSet<Customer>();
            SegmentOrans = new HashSet<SegmentOran>();
        }

        
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SegmentOran> SegmentOrans { get; set; }
    }
}
