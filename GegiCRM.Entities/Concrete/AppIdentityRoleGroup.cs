using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Concrete
{
    public class AppIdentityRoleGroup : BaseEntity<int>
    {
        public AppIdentityRoleGroup()
        {
            Roles = new HashSet<AppIdentityRole>();
        }

        public int Priority { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AppIdentityRole> Roles { get; set; }
    }
}
