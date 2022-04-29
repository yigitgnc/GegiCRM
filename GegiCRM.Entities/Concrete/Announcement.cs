using GegiCRM.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Concrete
{
    public class Announcement : IBaseEntity
    {
        
        public string Name { get; set; } = null!;
        public string? Descirption { get; set; }
    }
}
