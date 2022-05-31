using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class UserCompany : BaseEntity<int>        
    {
        public UserCompany()
        {
            BankInformations = new HashSet<BankInformation>();
            ShippingDeals = new HashSet<ShippingDeal>();
            Users = new HashSet<AppUser>();
            VehicleInformations = new HashSet<VehicleInformation>();
        }
        public new int? AddedById { get; set; }
        public new int? ModifiedById { get; set; }

        public string CompanyName { get; set; } = null!;
        public string? CompanyDescription { get; set; }
        public string? Tel { get; set; }
        public string? Fatura { get; set; }
        public string? TicaretSicilNo { get; set; }
        public string? MersisNo { get; set; }
        public string? FaliyetKodu { get; set; }
        public string? KepAdresi { get; set; }

        public virtual ICollection<BankInformation> BankInformations { get; set; }
        public virtual ICollection<ShippingDeal> ShippingDeals { get; set; }
        public new virtual ICollection<AppUser> Users { get; set; }
        public new virtual ICollection<VehicleInformation> VehicleInformations { get; set; }    
    }
}
