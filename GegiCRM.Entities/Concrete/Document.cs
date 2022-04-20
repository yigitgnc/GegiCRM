using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class Document
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid AddedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public string? DocumentName { get; set; }
        public string? DocumentDescription { get; set; }
        public string? DocumentDownloadPath { get; set; }
        public int? TypeId { get; set; }

        public virtual User AddedByNavigation { get; set; } = null!;
        public virtual User ModifiedByNavigation { get; set; } = null!;
        public virtual DocumentType? Type { get; set; }
    }
}
