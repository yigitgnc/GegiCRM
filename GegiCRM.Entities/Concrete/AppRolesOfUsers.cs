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
        public int AddedById { get; set; }
        public int? ModifiedById { get; set; }

        public virtual AppUser AddedBy { get; set; }
        public virtual AppUser? ModifiedBy { get; set; }

    }
}
