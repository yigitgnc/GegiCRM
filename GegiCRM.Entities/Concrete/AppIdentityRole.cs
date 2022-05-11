using GegiCRM.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class AppIdentityRole : IdentityRole<int>, IBaseEntity<int>
    {

        public bool IsDeleted { get; set; }
        public string? Description { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int AddedBy { get; set; }
        public int? ModifiedBy { get; set; }


        public int RoleGroupId { get; set; }

        public virtual AppAuthorizationRoleGroup RoleGroup { get; set; }
        public virtual AppUser AddedByNavigation { get; set; }
        public virtual AppUser? ModifiedByNavigation { get; set; }

    }
}
