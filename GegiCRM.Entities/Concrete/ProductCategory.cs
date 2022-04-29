using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class ProductCategory : IBaseEntity
    {
        
        public int ProductGroupId { get; set; }
        public string ProductCategoryName { get; set; } = null!;
        public string? ProductCategoryDescription { get; set; }

        public virtual ProductGroup ProductGroup { get; set; } = null!;
    }
}
