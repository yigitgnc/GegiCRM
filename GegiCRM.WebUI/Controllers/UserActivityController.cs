using GegiCRM.BLL.Generic;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.Controllers
{
    public class UserActivityController : Controller
    {
        private readonly GenericManager<UserActivityLog> manager = new GenericManager<UserActivityLog>(new GenericRepository<UserActivityLog>());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _GetUsersActivityLogs(int id)
        {
            var data = manager.ListByFilter(x => x.AddedById == id, false);
            return PartialView(data);
        }

    }
}
