using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public Order()
        {
            OrdersCurrencies = new HashSet<OrdersCurrency>();
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        
        public int CustomerId { get; set; }
        public int OrderStateId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool IsFrequentlyUsed { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual OrderAndProductState OrderState { get; set; } = null!;
        public virtual ICollection<OrdersCurrency> OrdersCurrencies { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
