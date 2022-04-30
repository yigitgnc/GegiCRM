using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class PaymentType : BaseEntity<int>
    {
        public PaymentType()
        {
            CollectionReceipts = new HashSet<CollectionReceipt>();
        }

        
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<CollectionReceipt> CollectionReceipts { get; set; }
    }
}
