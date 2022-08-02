using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class CustomerAddress : BaseEntity<int>
    {

        public int? CustomerId { get; set; }
        public string? AddressName { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Address { get; set; }
        public string? TeslimAlacakAdSoyad { get; set; }
        public string? TeslimTelefon { get; set; }
        public string? SonKullaniciBilgisi { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
