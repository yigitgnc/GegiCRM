using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Brand : BaseEntity<int>
    {
        public Brand()
        {
            Products = new HashSet<Product>();
            WarrantyTrackings = new HashSet<WarrantyTracking>();
            Suppliers = new HashSet<Supplier>();
        }

        
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<WarrantyTracking> WarrantyTrackings { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
