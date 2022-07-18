using GegiCRM.BLL.Generic;
using GegiCRM.DAL.Repositories;
using GegiCRM.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GegiCRM.WebUI.Utils.CustomActionFilters
{
    public class ActivityLogger : ActionFilterAttribute
    {
        private readonly GenericManager<UserActivityLog> _manager = new GenericManager<UserActivityLog>(new GenericRepository<UserActivityLog>());

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Stores the Request in an Accessible object
            var request = filterContext.HttpContext.Request;
            // Generate the log of user activity



            UserActivityLog log = new UserActivityLog()
            {
                // The IP Address of the Request
                IpAddress = request.HttpContext.Connection.RemoteIpAddress.ToString(),
                // The URL that was accessed
                Url = Microsoft.AspNetCore.Http.Extensions.UriHelper.GetDisplayUrl(request)
            };

            //saves the log to database
            _manager.Create(log);

            // Finishes executing the Action as normal 
            base.OnActionExecuting(filterContext);
        }
    }
}
