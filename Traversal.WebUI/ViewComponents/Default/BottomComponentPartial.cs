using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class BottomComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
