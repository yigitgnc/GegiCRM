using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class SupplierDetail : BaseEntity
    {
        
        public int SupplierId { get; set; }
        public decimal IadeKargoUcreti { get; set; }
        public decimal? ArizaKargoUcreti { get; set; }
        public string? MusteriTemsilcisi { get; set; }
        public string? Email { get; set; }
        public string? Gsm { get; set; }
        public string? IsTel { get; set; }
        public string? Dahili { get; set; }
        public DateTime? SıparisSaati { get; set; }
        public string? SiparisSiniri { get; set; }
        public string? YetkiliKisi { get; set; }
        public string? Notes { get; set; }
        public string? DepoAdres { get; set; }
        public string? GonderiTuru { get; set; }
        public string? Sevkiyat { get; set; }
        public string? KargoBedeliSatisSiniri { get; set; }
        public string? KargoBedeli { get; set; }
        public int CurrencyId { get; set; }
        public string? Vade { get; set; }
        public string? OdemeSekli { get; set; }

        public virtual Currency Currency { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
    }
}
