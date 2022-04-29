using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace GegiCRM.Entities.Concrete
{
    public class Rule : IBaseEntity
    {
        
        public string RuleName { get; set; } = null!;
        public string RuleDescription { get; set; } = null!;
    }
}
