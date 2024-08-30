using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
