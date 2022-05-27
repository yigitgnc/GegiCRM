using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GegiCRM.Entities.Abstract;

namespace GegiCRM.Entities.Concrete
{
    public class CustomerMainCompany : BaseEntity<int>
    {
        public CustomerMainCompany()
        {
            ChildCustomers = new HashSet<Customer>();
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Customer> ChildCustomers { get; set; }

    }
}
