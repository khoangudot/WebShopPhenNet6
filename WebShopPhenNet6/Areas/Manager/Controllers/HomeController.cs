using Microsoft.AspNetCore.Mvc;

namespace WebShopPhenNet6.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
