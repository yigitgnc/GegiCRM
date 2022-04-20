using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class CustomerDetail
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string? Tel { get; set; }
        public int CurrencyId { get; set; }
        public string? SideSuppliers { get; set; }
        public string? Notes { get; set; }

        public virtual Currency Currency { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
    }
}
