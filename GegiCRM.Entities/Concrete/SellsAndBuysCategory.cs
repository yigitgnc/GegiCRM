using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public  class SellsAndBuysCategory : BaseEntity<int>
    {
        public SellsAndBuysCategory()
        {
            SellsAndBuysAssets = new HashSet<SellsAndBuysAsset>();
            SellsAndBuysGuideSteps = new HashSet<SellsAndBuysGuideStep>();
        }

        
        public string CategoryName { get; set; } = null!;
        public string? CategoryDescription { get; set; }

        public virtual ICollection<SellsAndBuysAsset> SellsAndBuysAssets { get; set; }
        public virtual ICollection<SellsAndBuysGuideStep> SellsAndBuysGuideSteps { get; set; }
    }
}
