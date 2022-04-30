using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Bank : BaseEntity<int>
    {
        public Bank()
        {
            BankInformations = new HashSet<BankInformation>();
        }

        
        public bool IsDeleted { get; set; }
        public string BankName { get; set; } = null!;
        public string? BankDescirption { get; set; }

        public virtual ICollection<BankInformation> BankInformations { get; set; }
    }
}
