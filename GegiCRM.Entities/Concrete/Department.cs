using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Department
    {
        public Department()
        {
            DepartmentsOfUsers = new HashSet<DepartmentsOfUser>();
            EmailTemplates = new HashSet<EmailTemplate>();
            WorkStandarts = new HashSet<WorkStandart>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? DepartmentDescription { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual ICollection<DepartmentsOfUser> DepartmentsOfUsers { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplates { get; set; }
        public virtual ICollection<WorkStandart> WorkStandarts { get; set; }
    }
}
