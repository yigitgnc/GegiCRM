using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class SellsAndBuysGuideStep : BaseEntity<int>
    {
        public SellsAndBuysGuideStep()
        {
            SellsAndBuysAssets = new HashSet<SellsAndBuysAsset>();
        }

        
        public int? StepCount { get; set; }
        public string? StepName { get; set; }
        public string? StepDescription { get; set; }
        public int SabcategoryId { get; set; }
        public bool IsSell { get; set; }

        public virtual SellsAndBuysCategory Sabcategory { get; set; } = null!;
        public virtual ICollection<SellsAndBuysAsset> SellsAndBuysAssets { get; set; }
    }
}
