using Microsoft.AspNetCore.Mvc;

namespace TrainotrackWeb.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
