using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Sector : IBaseEntity
    {
        public Sector()
        {
            Customers = new HashSet<Customer>();
        }

        
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
