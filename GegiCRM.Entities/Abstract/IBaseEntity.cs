using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Abstract
{
    public interface IBaseEntity<Tkey>
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Tkey Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int AddedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public AppUser AddedByNavigation { get; set; }
        public AppUser? ModifiedByNavigation { get; set; } 
    }
}
