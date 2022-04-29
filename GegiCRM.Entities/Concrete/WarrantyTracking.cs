using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class WarrantyTracking : IBaseEntity
    {
        
        public int ProductCategoryId { get; set; }
        public int BrandId { get; set; }
        public string? Tel { get; set; }
        public string? Description { get; set; }

        public virtual Brand Brand { get; set; } = null!;
    }
}
