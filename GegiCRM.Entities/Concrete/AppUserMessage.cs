using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Concrete
{
    public class AppUserMessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime? ReadDate { get; set; }
        public int SenderUserId { get; set; }
        public int RecieverUserId { get; set; }
        public string? Message { get; set; }

        public virtual AppUser SenderUser { get; set; }
        public virtual AppUser RecieverUser { get; set; }

    }
}
