using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class ReturnAndFault
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int CustomerId { get; set; }
        public int? OrderIdIfExist { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public Guid RepresentitveUser { get; set; }
        public DateTime? PlannedDeadline { get; set; }
        public string? Description { get; set; }
        public int? CurrentStateId { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual ReturnAndFaultState? CurrentState { get; set; }
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual User RepresentitveUserNavigation { get; set; } = null!;
    }
}
