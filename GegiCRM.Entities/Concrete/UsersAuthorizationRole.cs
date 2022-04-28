using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class UsersAuthorizationRole : BaseEntity
    {
        public int UserId { get; set; }
        public int AuthorizationRoleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual AuthorizationsRole AuthorizationRole { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
