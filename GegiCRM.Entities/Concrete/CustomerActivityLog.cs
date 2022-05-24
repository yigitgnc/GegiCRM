using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Concrete
{
    public class CustomerActivityLog: BaseEntity<int>
    {
        public string? Note { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } 

    }
}
