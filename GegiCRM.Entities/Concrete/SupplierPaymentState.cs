using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class SupplierPaymentState : BaseEntity
    {
        public SupplierPaymentState()
        {
            SuppliersPayments = new HashSet<SuppliersPayment>();
        }

        
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<SuppliersPayment> SuppliersPayments { get; set; }
    }
}
