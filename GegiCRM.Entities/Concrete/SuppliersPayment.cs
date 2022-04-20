using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class SuppliersPayment
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int SupplierId { get; set; }
        public int? TaksitSayisi { get; set; }
        public decimal OdemeTutari { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrencyAmount { get; set; }
        public Guid PaymentOfficerUserId { get; set; }
        public int StateId { get; set; }
        public string? Descripiton { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual SupplierPaymentState State { get; set; } = null!;
    }
}
