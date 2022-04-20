using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Deposit
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int DepositRelationId { get; set; }
        public int DepositTypeId { get; set; }
        public string KurumAdi { get; set; } = null!;
        public string? IlgiliKisi { get; set; }
        public DateTime? VerilisTarihi { get; set; }
        public int CurrencyId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? BitisSuresi { get; set; }
        public string? Notes { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Currency Currency { get; set; } = null!;
        public virtual DepositRelation DepositRelation { get; set; } = null!;
        public virtual DepositType DepositType { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
    }
}
