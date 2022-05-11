using GegiCRM.Entities.Concrete;

namespace GegiCRM.WebUI.ViewComponents.UserTopNav
{
    public class TopNavUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ProfilePictureUrl { get; set; }
        public List<AppAuthorizationRoleGroup> UsersRoleGroups { get; set; }

    }
}
