using Microsoft.AspNetCore.Mvc;

namespace FurniWeb.App.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
