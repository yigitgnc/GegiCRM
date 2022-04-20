using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Birim
    {
        public Birim()
        {
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Short { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
