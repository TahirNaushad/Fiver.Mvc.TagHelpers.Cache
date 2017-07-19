using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.TagHelpers.Cache.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
