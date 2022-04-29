using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Birim : IBaseEntity
    {
        public Birim()
        {
            OrdersProducts = new HashSet<OrdersProduct>();
        }

        
        public string? Name { get; set; }
        public string? Short { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    }
}
