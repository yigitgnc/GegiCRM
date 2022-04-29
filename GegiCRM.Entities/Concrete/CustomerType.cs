using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class CustomerType : IBaseEntity
    {
        public CustomerType()
        {
            Customers = new HashSet<Customer>();
        }

        
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
