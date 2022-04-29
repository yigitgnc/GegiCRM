using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Product : IBaseEntity
    {
        public Product()
        {
            OrdersProducts = new HashSet<OrdersProduct>();
            Suppliers = new HashSet<Supplier>();
        }

        
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public int? ProductGroupId { get; set; }
        public int StockCount { get; set; }
        public int PorductBrandId { get; set; }
        public double KdvOrani { get; set; }

        public virtual Brand PorductBrand { get; set; } = null!;
        public virtual ProductGroup? ProductGroup { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
