using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;

namespace TraversalProject.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
          var values=featureManager.TGetList();
            return View(values);
        }
    }
}
