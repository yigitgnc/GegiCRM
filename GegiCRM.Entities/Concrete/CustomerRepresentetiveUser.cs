using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public partial class CustomerRepresentetiveUser
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
