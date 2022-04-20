using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            Documents = new HashSet<Document>();
        }

        public int Id { get; set; }
        public string? TypeName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
