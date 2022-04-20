using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class UserCompany
    {
        public UserCompany()
        {
            BankInformations = new HashSet<BankInformation>();
            ShippingDeals = new HashSet<ShippingDeal>();
            Users = new HashSet<User>();
            VehicleInformations = new HashSet<VehicleInformation>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? CompanyDescription { get; set; }
        public string? Tel { get; set; }
        public string? Fatura { get; set; }
        public string? TicaretSicilNo { get; set; }
        public string? MersisNo { get; set; }
        public string? FaliyetKodu { get; set; }
        public string? KepAdresi { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual ICollection<BankInformation> BankInformations { get; set; }
        public virtual ICollection<ShippingDeal> ShippingDeals { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<VehicleInformation> VehicleInformations { get; set; }
    }
}
