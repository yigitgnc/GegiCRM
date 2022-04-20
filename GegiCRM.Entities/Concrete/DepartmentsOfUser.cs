using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class DepartmentsOfUser
    {
        public Guid UserId { get; set; }
        public int DepartmentId { get; set; }
        public bool IsResponsible { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
