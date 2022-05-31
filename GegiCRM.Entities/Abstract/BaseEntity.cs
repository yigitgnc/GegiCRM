using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Abstract
{
    public abstract class BaseEntity<T> : IBaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int AddedById { get; set; }
        public int? ModifiedById { get; set; }
        public bool IsDeleted { get; set; }

        public virtual AppUser AddedBy{ get; set; } = null!;
        public virtual AppUser? ModifiedBy { get; set; } = null!;
    }
}
