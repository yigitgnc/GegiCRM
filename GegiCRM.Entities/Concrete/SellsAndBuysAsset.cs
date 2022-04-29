using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class SellsAndBuysAsset : IBaseEntity
    {
        
        public int SabcategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Notes { get; set; }
        public bool IsSell { get; set; }
        public int? CurrentStepId { get; set; }

        public virtual SellsAndBuysGuideStep? CurrentStep { get; set; }
        public virtual SellsAndBuysCategory Sabcategory { get; set; } = null!;
    }
}
