using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class SuppliersPayment : BaseEntity<int>
    {
        
        public int SupplierId { get; set; }
        public int? TaksitSayisi { get; set; }
        public decimal OdemeTutari { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrencyAmount { get; set; }
        public int PaymentOfficerUserId { get; set; }
        public int StateId { get; set; }
        public string? Descripiton { get; set; }

        public virtual SupplierPaymentState State { get; set; } = null!;
    }
}
