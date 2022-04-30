using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public  class DocumentType : BaseEntity<int>
    {
        public DocumentType()
        {
            Documents = new HashSet<Document>();
        }

        
        public string? TypeName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
