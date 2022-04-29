using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Abstract
{
    public interface IBaseEntity<Tkey>
    {
        public Tkey Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int AddedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public User AddedByNavigation { get; set; }
        public User? ModifiedByNavigation { get; set; } 
    }
}
