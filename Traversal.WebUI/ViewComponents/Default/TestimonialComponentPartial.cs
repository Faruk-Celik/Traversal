using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstract;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class TestimonialComponentPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialComponentPartial ( ITestimonialService testimonialService )
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetListAll();
            return View(values);
        }
    }
}
