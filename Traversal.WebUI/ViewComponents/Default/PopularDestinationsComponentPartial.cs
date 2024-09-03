using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstract;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class PopularDestinationsComponentPartial : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public PopularDestinationsComponentPartial ( IDestinationService destinationService )
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _destinationService.TGetListAll();
            return View(value);
        }
    }
}
