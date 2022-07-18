using GegiCRM.WebUI.Utils.CustomActionFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{
    [Authorize]
    [ActivityLogger]
    public class MailThemplatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
