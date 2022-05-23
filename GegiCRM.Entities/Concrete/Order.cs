using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Order : BaseEntity<int>
    {
        public Order()
        {
            OrdersCurrencies = new HashSet<OrdersCurrency>();
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        
        public int CustomerId { get; set; }
        public int OrderStateId { get; set; }
        public bool IsFrequentlyUsed { get; set; }
        public bool IsOfferApproved { get; set; }
        public DateTime? OfferApprovedDate { get; set; }
        public bool IsOrderApproved { get; set; }
        public DateTime? OrderApprovedDate { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime? CancelledDate { get; set; }
        public bool IsDeneied { get; set; }
        public DateTime? DeniedDate { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual OrderState OrderState { get; set; } = null!;
        public virtual ICollection<OrdersCurrency> OrdersCurrencies { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
