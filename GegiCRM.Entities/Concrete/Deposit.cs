using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Deposit : BaseEntity
    {
        public int Id { get; set; }
        public int DepositRelationId { get; set; }
        public int DepositTypeId { get; set; }
        public string KurumAdi { get; set; } = null!;
        public string? IlgiliKisi { get; set; }
        public DateTime? VerilisTarihi { get; set; }
        public int CurrencyId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? BitisSuresi { get; set; }
        public string? Notes { get; set; }

        public virtual Currency Currency { get; set; } = null!;
        public virtual DepositRelation DepositRelation { get; set; } = null!;
        public virtual DepositType DepositType { get; set; } = null!;
    }
}
