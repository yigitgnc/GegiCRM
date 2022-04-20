using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class CustomerAddress
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string? AddressName { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Address { get; set; }
        public bool IsDeliveryAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual User? ModifiedByNavigation { get; set; }
    }
}
