using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class DepositRelation : BaseEntity
    {
        public DepositRelation()
        {
            Deposits = new HashSet<Deposit>();
        }

        
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Deposit> Deposits { get; set; }
    }
}
