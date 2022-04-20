using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class ProductGroupsFaq
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int? ProductGroupId { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User? ModifiedByNavigation { get; set; }
        public virtual ProductGroup? ProductGroup { get; set; }
    }
}
