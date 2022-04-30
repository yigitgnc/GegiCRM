using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class CustomerContact : BaseEntity<int>
    {

        public int? CustomerId { get; set; }
        public string? ContactName { get; set; }
        public string? ContactSurname { get; set; }
        public string? ContactTitle { get; set; }
        public string? Tel { get; set; }
        public string? Gsm { get; set; }
        public string? Email { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual User ModifiedByNavigation { get; set; } = null!;
    }
}
