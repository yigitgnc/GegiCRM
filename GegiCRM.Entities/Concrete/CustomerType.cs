using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
