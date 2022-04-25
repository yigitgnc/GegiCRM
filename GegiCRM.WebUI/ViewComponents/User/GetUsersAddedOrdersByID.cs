using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.ViewComponents.User
{
    public class GetUsersAddedOrdersByID :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
