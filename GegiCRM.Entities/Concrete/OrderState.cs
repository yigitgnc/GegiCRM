using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public  class OrderState : BaseEntity<int>
    {
        public OrderState()
        {
            Orders = new HashSet<Order>();
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
