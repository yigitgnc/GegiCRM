using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Concrete
{
    public class UserActivityLog : BaseEntity<int>
    {
        public string Url { get; set; }
        public string IpAddress { get; set; }
    }
}
