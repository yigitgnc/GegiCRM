using GegiCRM.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class UsersAuthorizationRole : IdentityUserRole<int>, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //public virtual AuthorizationsRole AuthorizationRole { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int AddedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public virtual User AddedByNavigation { get; set; }
        public virtual User? ModifiedByNavigation { get; set; }
    }
}
