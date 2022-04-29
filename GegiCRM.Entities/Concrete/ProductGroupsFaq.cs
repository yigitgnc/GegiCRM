using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class ProductGroupsFaq : IBaseEntity
    {
        
        public int? ProductGroupId { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }

        public virtual ProductGroup? ProductGroup { get; set; }
    }
}
