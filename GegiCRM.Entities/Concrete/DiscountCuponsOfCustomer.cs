using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class DiscountCuponsOfCustomer : IBaseEntity
    {
        public int CustomerId { get; set; }
        public int DiscountCuponId { get; set; }
        public string? Description { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime ExpryDate { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual DiscountCupon DiscountCupon { get; set; } = null!;
    }
}
