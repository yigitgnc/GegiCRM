using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Supplier : BaseEntity<int>
    {
        public Supplier()
        {
            CollectionReceipts = new HashSet<CollectionReceipt>();
            OrdersProductKesinSuppliers = new HashSet<OrdersProduct>();
            OrdersProductReferansSuppliers = new HashSet<OrdersProduct>();
            SupplierDetails = new HashSet<SupplierDetail>();
            Brands = new HashSet<Brand>();
            MarketPlaces = new HashSet<MarketPlace>();
            ProductGroups = new HashSet<ProductGroup>();
            Products = new HashSet<Product>();
        }

        
        public string? SupplierName { get; set; }
        public string? OncelikSirasi { get; set; }
        public string? Url { get; set; }
        public string? DealerCode { get; set; }
        public DateTime? LastContactDate { get; set; }

        public virtual ICollection<CollectionReceipt> CollectionReceipts { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProductKesinSuppliers { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProductReferansSuppliers { get; set; }
        public virtual ICollection<SupplierDetail> SupplierDetails { get; set; }

        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<MarketPlace> MarketPlaces { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
