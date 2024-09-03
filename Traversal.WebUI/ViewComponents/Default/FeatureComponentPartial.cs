using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Abstract;
using Traversal.DataAccessLayer.Context;

namespace Traversal.WebUI.ViewComponents.Default
{
    public class FeatureComponentPartial :ViewComponent
    {
        private readonly IFeatureService _featureService;

        public FeatureComponentPartial ( IFeatureService featureService )
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke ()
        {
            var value = _featureService.TGetListAll();
            return View(value);
        }
    }
}
