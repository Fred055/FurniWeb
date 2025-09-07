using Microsoft.AspNetCore.Mvc;

namespace FurniWeb.App.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
