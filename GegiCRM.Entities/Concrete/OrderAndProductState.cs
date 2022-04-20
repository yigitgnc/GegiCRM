using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class OrderAndProductState
    {
        public OrderAndProductState()
        {
            Orders = new HashSet<Order>();
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
