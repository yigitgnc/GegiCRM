using Microsoft.AspNetCore.Mvc;

namespace GegiCRM.WebUI.ViewComponents.TopNavSearch
{

    public class TopNavSearch : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = new SearchResultsModel();
            return View<SearchResultsModel>(data);
        }

    }
}
