using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var deger = subAboutManager.TGetList();
            return View(deger);
        }
    }
}
