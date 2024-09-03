using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccessLayer.Context;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class StatsComponentPartial: ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            using var c = new TraversalContext();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "1256";

            return View();
        }
    }
}
