﻿using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class ServiceReason : IBaseEntity
    {
        public ServiceReason()
        {
            ServiceRecords = new HashSet<ServiceRecord>();
        }

        
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<ServiceRecord> ServiceRecords { get; set; }
    }
}
