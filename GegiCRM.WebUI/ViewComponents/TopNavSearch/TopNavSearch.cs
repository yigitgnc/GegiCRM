using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.ViewComponents.TopNavSearch
{

    public class TopNavSearch : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            return View();
        }

    }
}
