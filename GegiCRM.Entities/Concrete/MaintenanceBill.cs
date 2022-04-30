using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class MaintenanceBill : BaseEntity<int>
    {
        
        public int? CustomerId { get; set; }
        public int? SellingRepresentetiveUserId { get; set; }
        public int? CustomerRepresentetiveUserId { get; set; }
        public int ProductGroupId { get; set; }
        public int MaintenencePeriodId { get; set; }
        public TimeSpan? MainteneceTime { get; set; }
        public decimal SozlesmeBedeli { get; set; }
        public int CurrencyId { get; set; }
        public DateTime? SozlesmeBaslangicTarihi { get; set; }
        public DateTime? SozlesmeBitisTarihi { get; set; }
        public string? Note { get; set; }

        public virtual Currency Currency { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual User? CustomerRepresentetiveUser { get; set; }
        public virtual MaintenencePeriod MaintenencePeriod { get; set; } = null!;
        public virtual ProductGroup ProductGroup { get; set; } = null!;
        public virtual User? SellingRepresentetiveUser { get; set; }
    }
}
