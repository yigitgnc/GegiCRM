using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class OrdersProductCurrency : BaseEntity<int>
    {
        public int OrdersProductId { get; set; }
        public int CurrencyId { get; set; }
        public decimal? Value { get; set; }

        public virtual Currency Currency { get; set; } = null!;
        public virtual OrdersProduct OrdersProduct { get; set; } = null!;
    }
}
