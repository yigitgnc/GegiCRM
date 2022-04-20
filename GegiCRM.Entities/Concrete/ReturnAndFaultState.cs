using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class ReturnAndFaultState
    {
        public ReturnAndFaultState()
        {
            ReturnAndFaults = new HashSet<ReturnAndFault>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string StatName { get; set; } = null!;
        public string? StatDescription { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual ICollection<ReturnAndFault> ReturnAndFaults { get; set; }
    }
}
