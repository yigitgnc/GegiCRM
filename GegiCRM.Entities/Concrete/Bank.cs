using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Bank
    {
        public Bank()
        {
            BankInformations = new HashSet<BankInformation>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string BankName { get; set; } = null!;
        public string? BankDescirption { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual ICollection<BankInformation> BankInformations { get; set; }
    }
}
