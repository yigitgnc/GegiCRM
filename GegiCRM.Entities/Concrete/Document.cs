using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public  class Document : BaseEntity
    {
        
        public string? DocumentName { get; set; }
        public string? DocumentDescription { get; set; }
        public string? DocumentDownloadPath { get; set; }
        public int? TypeId { get; set; }

        public virtual DocumentType? Type { get; set; }
    }
}
