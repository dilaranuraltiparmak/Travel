using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalProject.ViewComponents.Default
{
    public class _Statistic:ViewComponent
    { public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v2 = "245";
            return View();  
        }
    }
}
