using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class MaintenencePeriod : BaseEntity
    {
        public MaintenencePeriod()
        {
            MaintenanceBills = new HashSet<MaintenanceBill>();
        }

        
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<MaintenanceBill> MaintenanceBills { get; set; }
    }
}
