using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class CustomerBillingAddress : BaseEntity
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string? AddressName { get; set; }
        public string? VergiNo { get; set; }
        public string? VergiDairesi { get; set; }
        public string? BillingAddress { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
