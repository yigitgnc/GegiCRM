using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class CustomerDetail : IBaseEntity
    {
        
        public int CustomerId { get; set; }
        public string? Tel { get; set; }
        public int CurrencyId { get; set; }
        public string? SideSuppliers { get; set; }
        public string? Notes { get; set; }

        public virtual Currency Currency { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
    }
}
