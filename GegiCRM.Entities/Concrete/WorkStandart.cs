using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class WorkStandart
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public string? Period { get; set; }
        public DateTime? ApplicationCalendar { get; set; }
        public string? AvalibleHours { get; set; }
        public string? WorkTime { get; set; }
        public string? WorkDefinition { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Department Department { get; set; } = null!;
        public virtual User? ModifiedByNavigation { get; set; }
    }
}
