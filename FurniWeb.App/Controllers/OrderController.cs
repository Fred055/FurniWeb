using Microsoft.AspNetCore.Mvc;

namespace FurniWeb.App.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
