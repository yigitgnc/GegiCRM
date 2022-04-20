using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class EmailTemplate
    {
        public int Id { get; set; }
        public string Explanation { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string MailContent { get; set; } = null!;
        public string? Notes { get; set; }
        public int? DepartmentId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Department? Department { get; set; }
        public virtual User ModifiedByNavigation { get; set; } = null!;
    }
}
