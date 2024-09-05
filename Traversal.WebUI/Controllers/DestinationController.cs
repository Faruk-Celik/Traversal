using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstract;
using Traversal.EntityLayer.Concrete;

namespace Traversal.WebUI.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController ( IDestinationService destinationService )
        {
            _destinationService = destinationService;
        }

        public IActionResult Index ()
        {
            var value = _destinationService.TGetListAll();
            return View(value);
        }
        [HttpGet]
        public IActionResult DestinationDetails ( int id)
        {
            var values = _destinationService.TGetById(id);
            ViewBag.i = id;
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails ( Destination p)
        {
            return View();
        }
    }
}
