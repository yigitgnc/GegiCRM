using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class ShippingDeal
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual UserCompany Company { get; set; } = null!;
    }
}
