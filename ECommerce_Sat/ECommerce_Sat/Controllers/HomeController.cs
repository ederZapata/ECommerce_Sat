using Microsoft.AspNetCore.Mvc;

namespace ECommerce_Sat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
