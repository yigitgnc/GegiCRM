using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Rule
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string RuleName { get; set; } = null!;
        public string RuleDescription { get; set; } = null!;

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
    }
}
