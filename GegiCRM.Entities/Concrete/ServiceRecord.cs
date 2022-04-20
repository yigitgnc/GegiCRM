using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class ServiceRecord
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int CustomerId { get; set; }
        public string? ArizaTanimi { get; set; }
        public Guid ServicePersonalUser { get; set; }
        public DateTime ServiceBeginDate { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public string? YapilacakIslem { get; set; }
        public int ServiceReasonId { get; set; }
        public int ServiceTypeId { get; set; }
        public int ServicePlaceId { get; set; }
        public string? MudahaleEdilenCihaz { get; set; }
        public string? MudahaleEdilenModel { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual User ServicePersonalUserNavigation { get; set; } = null!;
        public virtual ServicePlace ServicePlace { get; set; } = null!;
        public virtual ServiceReason ServiceReason { get; set; } = null!;
        public virtual ServiceType ServiceType { get; set; } = null!;
    }
}
