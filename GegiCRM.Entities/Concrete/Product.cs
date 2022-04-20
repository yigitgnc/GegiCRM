using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Product
    {
        public Product()
        {
            OrdersProducts = new HashSet<OrdersProduct>();
            Suppliers = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public int? ProductGroupId { get; set; }
        public int StockCount { get; set; }
        public int PorductBrandId { get; set; }
        public double KdvOrani { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual Brand PorductBrand { get; set; } = null!;
        public virtual ProductGroup? ProductGroup { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
