using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index(int? statusCode = null)
        {
            if (statusCode.HasValue)
            {
                // here is the trick
                this.HttpContext.Response.StatusCode = statusCode.Value;
            }
            ViewBag.StatusCode = this.HttpContext.Response.StatusCode;
            return View();
        }
    }
}
