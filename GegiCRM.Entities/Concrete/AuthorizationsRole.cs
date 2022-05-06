using GegiCRM.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class AuthorizationsRole : IdentityRole<int>, IBaseEntity<int>
    {
        public AuthorizationsRole()
        {
            //UsersAuthorizationRoles = new HashSet<UsersAuthorizationRole>();
        }

        
        public bool IsDeleted { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        //public virtual ICollection<UsersAuthorizationRole> UsersAuthorizationRoles { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int AddedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public virtual AppUser AddedByNavigation { get; set; }
        public virtual AppUser? ModifiedByNavigation { get; set; }
    }
}
