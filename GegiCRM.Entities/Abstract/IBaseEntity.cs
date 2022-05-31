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
        public int AddedById { get; set; }
        public int? ModifiedById { get; set; }
        public bool IsDeleted { get; set; }

        public AppUser AddedBy { get; set; }
        public AppUser? ModifiedBy { get; set; } 
    }
}
