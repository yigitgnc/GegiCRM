using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Order
    {
        public Order()
        {
            OrdersCurrencies = new HashSet<OrdersCurrency>();
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int CustomerId { get; set; }
        public int OrderStateId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool IsFrequentlyUsed { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual OrderAndProductState OrderState { get; set; } = null!;
        public virtual ICollection<OrdersCurrency> OrdersCurrencies { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
