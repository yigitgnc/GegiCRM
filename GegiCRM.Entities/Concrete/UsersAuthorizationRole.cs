using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class UsersAuthorizationRole
    {
        public Guid UserId { get; set; }
        public int AuthorizationRoleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual AuthorizationsRole AuthorizationRole { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
