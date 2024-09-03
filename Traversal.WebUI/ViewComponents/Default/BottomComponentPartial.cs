using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstract;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class BottomComponentPartial:ViewComponent
    {  
        private readonly ISubAboutService _subAboutService;

        public BottomComponentPartial ( ISubAboutService subAboutService )
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _subAboutService.TGetListAll();
            return View(values);
        }
    }
}
