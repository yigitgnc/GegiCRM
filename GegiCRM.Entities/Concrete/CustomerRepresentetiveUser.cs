using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class CustomerRepresentetiveUser : IBaseEntity
    {
        
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
