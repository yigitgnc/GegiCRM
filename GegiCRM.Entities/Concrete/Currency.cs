using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Currency : BaseEntity<int>
    {
        public Currency()
        {
            CollectionReceipts = new HashSet<CollectionReceipt>();
            CustomerDetails = new HashSet<CustomerDetail>();
            Deposits = new HashSet<Deposit>();
            DiscountCupons = new HashSet<DiscountCupon>();
            MaintenanceBills = new HashSet<MaintenanceBill>();
            OrdersCurrencies = new HashSet<OrdersCurrency>();
            OrdersProductKesinCurrencies = new HashSet<OrdersProduct>();
            OrdersProductReferansCurrencies = new HashSet<OrdersProduct>();
            SupplierDetails = new HashSet<SupplierDetail>();
        }

        
        public string Code { get; set; } = null!;
        public string? Name { get; set; }

        public virtual ICollection<CollectionReceipt> CollectionReceipts { get; set; }
        public virtual ICollection<CustomerDetail> CustomerDetails { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<DiscountCupon> DiscountCupons { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBills { get; set; }
        public virtual ICollection<OrdersCurrency> OrdersCurrencies { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProductKesinCurrencies { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProductReferansCurrencies { get; set; }
        public virtual ICollection<SupplierDetail> SupplierDetails { get; set; }
    }
}
