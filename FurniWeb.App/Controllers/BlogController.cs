using Microsoft.AspNetCore.Mvc;

namespace FurniWeb.App.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
