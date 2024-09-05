using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.ViewComponents.Comment
{
    public class AddCommentComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
