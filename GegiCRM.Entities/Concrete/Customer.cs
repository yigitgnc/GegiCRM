using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Customer : BaseEntity<int>
    {
        public Customer()
        {
            CollectionReceipts = new HashSet<CollectionReceipt>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            CustomerBillingAddresses = new HashSet<CustomerBillingAddress>();
            CustomerContacts = new HashSet<CustomerContact>();
            //CustomerDetails = new HashSet<CustomerDetail>();
            CustomerRepresentetiveUsers = new HashSet<CustomerRepresentetiveUser>();
            DiscountCuponsOfCustomers = new HashSet<DiscountCuponsOfCustomer>();
            MaintenanceBills = new HashSet<MaintenanceBill>();
            Orders = new HashSet<Order>();
            ServiceRecords = new HashSet<ServiceRecord>();
        }


        public bool IsDeleted { get; set; }
        public string? TicariUnvan { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? SectorId { get; set; }
        public string? CariKodu { get; set; }
        public int SegmentId { get; set; }
        public bool? IsActive { get; set; }
        public int TypeId { get; set; }
        public DateTime? LastContactDate { get; set; }

        public string? Tel { get; set; }
        public int CurrencyId { get; set; }
        public string? SideSuppliers { get; set; }
        public string? Notes { get; set; }

        public int? PreferredCurrencyId { get; set; }
        public virtual Currency? PreferredCurrency { get; set; } = null!;
        public int CustomerMainCompanyId { get; set; }
        public virtual CustomerMainCompany CustomerMainCompany { get; set; }
        public virtual Sector? Sector { get; set; }
        public virtual Segment Segment { get; set; } = null!;
        public virtual CustomerType Type { get; set; } = null!;
        public virtual ICollection<CollectionReceipt> CollectionReceipts { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<CustomerBillingAddress> CustomerBillingAddresses { get; set; }
        public virtual ICollection<CustomerContact> CustomerContacts { get; set; }
        //public virtual ICollection<CustomerDetail> CustomerDetails { get; set; }
        public virtual ICollection<CustomerRepresentetiveUser> CustomerRepresentetiveUsers { get; set; }
        public virtual ICollection<DiscountCuponsOfCustomer> DiscountCuponsOfCustomers { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBills { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecords { get; set; }
    }
}
