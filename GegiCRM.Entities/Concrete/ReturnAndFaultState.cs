using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class ReturnAndFaultState : BaseEntity<int>
    {
        public ReturnAndFaultState()
        {
            ReturnAndFaults = new HashSet<ReturnAndFault>();
        }

        
        public string StatName { get; set; } = null!;
        public string? StatDescription { get; set; }

        public virtual ICollection<ReturnAndFault> ReturnAndFaults { get; set; }
    }
}
