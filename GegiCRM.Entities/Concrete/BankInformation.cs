using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class BankInformation : IBaseEntity
    {
        
        public int CompanyId { get; set; }
        public int BankId { get; set; }
        public string Ttile { get; set; } = null!;
        public string? HesapNo { get; set; }
        public string? Sube { get; set; }
        public int? SubeNo { get; set; }
        public string? Iban { get; set; }

        public virtual Bank Bank { get; set; } = null!;
        public virtual UserCompany Company { get; set; } = null!;
    }
}
