using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class VehicleInformation : IBaseEntity
    {
        
        public int UserCompanyId { get; set; }
        public string Plaka { get; set; } = null!;
        public short ModelYear { get; set; }
        public string Brand { get; set; } = null!;
        public DateTime? TescilTarihi { get; set; }
        public DateTime? TrafikSigPoliceBitisTarihi { get; set; }
        public DateTime? KaskoPoliceBitisTarihi { get; set; }
        public DateTime? GelecekMuayeneTarihi { get; set; }
        public int? SonBakimKm { get; set; }
        public int? BakimKmperiod { get; set; }
        public DateTime? SonBakimTarihi { get; set; }
        public DateTime? SonrakiBakimTarihi { get; set; }
        public int? KiraToplamKmtaahhut { get; set; }
        public DateTime? KiraBitisTarihi { get; set; }
        public int? BazKm { get; set; }
        public int? SonOkunanKm { get; set; }
        public DateTime? SonOkunanKmtarihi { get; set; }
        public DateTime? KisLastigiDegisimTarihi { get; set; }
        public DateTime? YazLastigiDegisimTarihi { get; set; }
        public DateTime? K2belgesiBitisTarihi { get; set; }
        public DateTime? TakipCihaziYenilemeTarihi { get; set; }
        public string? Note { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual UserCompany UserCompany { get; set; } = null!;
    }
}
