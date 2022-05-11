using GegiCRM.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GegiCRM.Entities.Concrete
{
    public class AppRolesOfUsers : IdentityUserRole<int>, IBaseEntity<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int AddedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual AppUser AddedByNavigation { get; set; }
        public virtual AppUser? ModifiedByNavigation { get; set; }

    }
}
