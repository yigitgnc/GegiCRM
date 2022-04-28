using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public  class SellsAndBuysCategory : BaseEntity
    {
        public SellsAndBuysCategory()
        {
            SellsAndBuysAssets = new HashSet<SellsAndBuysAsset>();
            SellsAndBuysGuideSteps = new HashSet<SellsAndBuysGuideStep>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? CategoryDescription { get; set; }

        public virtual ICollection<SellsAndBuysAsset> SellsAndBuysAssets { get; set; }
        public virtual ICollection<SellsAndBuysGuideStep> SellsAndBuysGuideSteps { get; set; }
    }
}
