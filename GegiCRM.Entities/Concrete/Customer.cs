using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Customer
    {
        public Customer()
        {
            CollectionReceipts = new HashSet<CollectionReceipt>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            CustomerBillingAddresses = new HashSet<CustomerBillingAddress>();
            CustomerContacts = new HashSet<CustomerContact>();
            CustomerDetails = new HashSet<CustomerDetail>();
            CustomerRepresentetiveUsers = new HashSet<CustomerRepresentetiveUser>();
            DiscountCuponsOfCustomers = new HashSet<DiscountCuponsOfCustomer>();
            MaintenanceBills = new HashSet<MaintenanceBill>();
            Orders = new HashSet<Order>();
            ServiceRecords = new HashSet<ServiceRecord>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
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

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual Sector? Sector { get; set; }
        public virtual Segment Segment { get; set; } = null!;
        public virtual CustomerType Type { get; set; } = null!;
        public virtual ICollection<CollectionReceipt> CollectionReceipts { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<CustomerBillingAddress> CustomerBillingAddresses { get; set; }
        public virtual ICollection<CustomerContact> CustomerContacts { get; set; }
        public virtual ICollection<CustomerDetail> CustomerDetails { get; set; }
        public virtual ICollection<CustomerRepresentetiveUser> CustomerRepresentetiveUsers { get; set; }
        public virtual ICollection<DiscountCuponsOfCustomer> DiscountCuponsOfCustomers { get; set; }
        public virtual ICollection<MaintenanceBill> MaintenanceBills { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ServiceRecord> ServiceRecords { get; set; }
    }
}
