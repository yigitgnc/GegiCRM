using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class ShippingDeal : BaseEntity
    {
        
        public int CompanyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual UserCompany Company { get; set; } = null!;
    }
}
