using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class DepositType : BaseEntity<int>
    {
        public DepositType()
        {
            Deposits = new HashSet<Deposit>();
        }

        
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Deposit> Deposits { get; set; }
    }
}
