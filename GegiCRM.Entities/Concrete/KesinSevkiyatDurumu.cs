using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Concrete
{
    public class KesinSevkiyatDurumu : BaseEntity<int>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
