﻿using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class ReturnAndFaultState : BaseEntity
    {
        public ReturnAndFaultState()
        {
            ReturnAndFaults = new HashSet<ReturnAndFault>();
        }

        public int Id { get; set; }
        public string StatName { get; set; } = null!;
        public string? StatDescription { get; set; }

        public virtual ICollection<ReturnAndFault> ReturnAndFaults { get; set; }
    }
}
