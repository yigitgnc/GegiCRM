using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{
    public class Error : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
