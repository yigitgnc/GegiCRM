using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Department:BaseEntity
    {
        public Department()
        {
            DepartmentsOfUsers = new HashSet<DepartmentsOfUser>();
            EmailTemplates = new HashSet<EmailTemplate>();
            WorkStandarts = new HashSet<WorkStandart>();
        }

        public int Id { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? DepartmentDescription { get; set; }

        public virtual ICollection<DepartmentsOfUser> DepartmentsOfUsers { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplates { get; set; }
        public virtual ICollection<WorkStandart> WorkStandarts { get; set; }
    }
}
