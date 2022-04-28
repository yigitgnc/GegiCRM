using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class ProductGroup : BaseEntity
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
        public string? GroupName { get; set; }
        public string? GroupDescription { get; set; }

        public virtual ICollection<MaintenanceBill> MaintenanceBills { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<ProductGroupsFaq> ProductGroupsFaqs { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
