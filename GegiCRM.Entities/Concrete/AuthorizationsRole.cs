using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class AuthorizationsRole : BaseEntity
    {
        public AuthorizationsRole()
        {
            UsersAuthorizationRoles = new HashSet<UsersAuthorizationRole>();
        }

        
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<UsersAuthorizationRole> UsersAuthorizationRoles { get; set; }
    }
}
