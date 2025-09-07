using Microsoft.AspNetCore.Mvc;

namespace FurniWeb.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
