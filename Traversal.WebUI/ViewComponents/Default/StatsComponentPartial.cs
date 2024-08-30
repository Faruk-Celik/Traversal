using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class StatsComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
