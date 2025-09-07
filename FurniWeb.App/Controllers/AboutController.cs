using Microsoft.AspNetCore.Mvc;

namespace FurniWeb.App.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
