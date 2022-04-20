using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            CollectionReceipts = new HashSet<CollectionReceipt>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual ICollection<CollectionReceipt> CollectionReceipts { get; set; }
    }
}
