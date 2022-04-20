using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class SellsAndBuysGuideStep
    {
        public SellsAndBuysGuideStep()
        {
            SellsAndBuysAssets = new HashSet<SellsAndBuysAsset>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int? StepCount { get; set; }
        public string? StepName { get; set; }
        public string? StepDescription { get; set; }
        public int SabcategoryId { get; set; }
        public bool IsSell { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual SellsAndBuysCategory Sabcategory { get; set; } = null!;
        public virtual ICollection<SellsAndBuysAsset> SellsAndBuysAssets { get; set; }
    }
}
