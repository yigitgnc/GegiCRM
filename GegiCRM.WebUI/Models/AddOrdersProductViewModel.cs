using System.Security.AccessControl;
using GegiCRM.Entities.Concrete;

namespace GegiCRM.WebUI.Models
{
    public class AddOrdersProductViewModel
    {
        public int CurrentOrderId { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductGroup> ProductGroups { get; set; }
        public IEnumerable<Birim> Birims { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Supplier> Suppliers { get; set; }
        public IEnumerable<Currency> Currencies { get; set; }
        public List<KesinSevkiyatDurumu> KesinSevkiyatDurums { get; set; }
        public OrdersProduct OrderProduct { get; set; }

    }
}
