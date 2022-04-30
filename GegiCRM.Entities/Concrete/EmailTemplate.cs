using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class EmailTemplate : BaseEntity<int>
    {
        
        public string Explanation { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string MailContent { get; set; } = null!;
        public string? Notes { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }
}
