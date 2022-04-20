using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class SellsAndBuysAsset
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int SabcategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Notes { get; set; }
        public bool IsSell { get; set; }
        public int? CurrentStepId { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual SellsAndBuysGuideStep? CurrentStep { get; set; }
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual SellsAndBuysCategory Sabcategory { get; set; } = null!;
    }
}
