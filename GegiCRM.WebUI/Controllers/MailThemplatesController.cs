using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{
    public class MailThemplatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
