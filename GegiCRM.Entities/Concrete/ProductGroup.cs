using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            MaintenanceBills = new HashSet<MaintenanceBill>();
            ProductCategories = new HashSet<ProductCategory>();
            ProductGroupsFaqs = new HashSet<ProductGroupsFaq>();
            Products = new HashSet<Product>();
            Suppliers = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public string? GroupName { get; set; }
        public string? GroupDescription { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<MaintenanceBill> MaintenanceBills { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<ProductGroupsFaq> ProductGroupsFaqs { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
