using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class WorkStandart : BaseEntity
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public string? Period { get; set; }
        public DateTime? ApplicationCalendar { get; set; }
        public string? AvalibleHours { get; set; }
        public string? WorkTime { get; set; }
        public string? WorkDefinition { get; set; }

        public virtual Department Department { get; set; } = null!;
    }
}
