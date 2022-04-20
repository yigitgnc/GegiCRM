using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class CustomerContact
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
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
