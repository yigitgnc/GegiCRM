using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class DepartmentsOfUser : BaseEntity<int>
    {
        public int UserId { get; set; }
        public int DepartmentId { get; set; }
        public bool IsResponsible { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual AppUser User { get; set; } = null!;
    }
}
