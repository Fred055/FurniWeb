using Microsoft.AspNetCore.Mvc;

namespace FurniWeb.App.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
