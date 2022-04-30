using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class OrdersCurrency : BaseEntity<int>
    {
        public int OrderId { get; set; }
        public int CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }

        public virtual Currency Currency { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
