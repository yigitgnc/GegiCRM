using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class DiscountCuponsOfCustomer
    {
        public int CustomerId { get; set; }
        public int DiscountCuponId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public string? Description { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime ExpryDate { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual DiscountCupon DiscountCupon { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
    }
}
