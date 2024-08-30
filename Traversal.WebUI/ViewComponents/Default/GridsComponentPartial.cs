using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class GridsComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
