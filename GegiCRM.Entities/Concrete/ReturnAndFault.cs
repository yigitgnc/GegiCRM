using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class ReturnAndFault : BaseEntity<int>
    {
        
        public int CustomerId { get; set; }
        public int? OrderIdIfExist { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int RepresentitveUser { get; set; }
        public DateTime? PlannedDeadline { get; set; }
        public string? Description { get; set; }
        public int? CurrentStateId { get; set; }

        public virtual ReturnAndFaultState? CurrentState { get; set; }
        public virtual AppUser RepresentitveUserNavigation { get; set; } = null!;
    }
}
