using Microsoft.AspNetCore.Mvc;

namespace FurniWeb.App.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
