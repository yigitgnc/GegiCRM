using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class MaintenanceBill
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int? CustomerId { get; set; }
        public Guid? SellingRepresentetiveUserId { get; set; }
        public Guid? CustomerRepresentetiveUserId { get; set; }
        public int ProductGroupId { get; set; }
        public int MaintenencePeriodId { get; set; }
        public TimeSpan? MainteneceTime { get; set; }
        public decimal SozlesmeBedeli { get; set; }
        public int CurrencyId { get; set; }
        public DateTime? SozlesmeBaslangicTarihi { get; set; }
        public DateTime? SozlesmeBitisTarihi { get; set; }
        public string? Note { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Currency Currency { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual User? CustomerRepresentetiveUser { get; set; }
        public virtual MaintenencePeriod MaintenencePeriod { get; set; } = null!;
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual ProductGroup ProductGroup { get; set; } = null!;
        public virtual User? SellingRepresentetiveUser { get; set; }
    }
}
