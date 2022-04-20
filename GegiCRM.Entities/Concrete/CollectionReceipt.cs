using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class CollectionReceipt
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrencyExchange { get; set; }
        public int PaymentTypeId { get; set; }
        public short Taksit { get; set; }
        public decimal TotalAmount { get; set; }
        public string? KartinUstundekiIsım { get; set; }
        public string? NameSurname { get; set; }

        public virtual Currency Currency { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual PaymentType PaymentType { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
    }
}
