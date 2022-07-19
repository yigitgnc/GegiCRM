using GegiCRM.Entities.Concrete;

namespace GegiCRM.WebUI.Models
{
    public class UserMessagesViewModel
    {
        public AppUser User { get; set; }
        public UserMessage? LastMessage { get; set; }
    }
}
