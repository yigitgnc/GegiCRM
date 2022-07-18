using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.Entities.Concrete
{
    public class UserDailyActivityLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public TimeSpan TotalActiveTime { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastLogoutDate { get; set; }
        public string? LastVisitedPageTitle { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}
