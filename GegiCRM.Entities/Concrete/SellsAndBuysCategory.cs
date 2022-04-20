using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class SellsAndBuysCategory
    {
        public SellsAndBuysCategory()
        {
            SellsAndBuysAssets = new HashSet<SellsAndBuysAsset>();
            SellsAndBuysGuideSteps = new HashSet<SellsAndBuysGuideStep>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? CategoryDescription { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<SellsAndBuysAsset> SellsAndBuysAssets { get; set; }
        public virtual ICollection<SellsAndBuysGuideStep> SellsAndBuysGuideSteps { get; set; }
    }
}
