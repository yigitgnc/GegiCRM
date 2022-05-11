using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Concrete
{
    public class AppAuthorizationRoleGroup : BaseEntity<int>
    {
        public AppAuthorizationRoleGroup()
        {
            Roles = new HashSet<AppAuthorizationsRole>();
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AppAuthorizationsRole> Roles { get; set; }
    }
}
