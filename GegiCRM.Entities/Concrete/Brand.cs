using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
            WarrantyTrackings = new HashSet<WarrantyTracking>();
            Suppliers = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<WarrantyTracking> WarrantyTrackings { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
