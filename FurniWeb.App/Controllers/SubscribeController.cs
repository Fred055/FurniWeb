
using FurniWeb.App.Context;
using FurniWeb.App.Dtos.Subscribe;
using FurniWeb.App.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FurniWeb.App.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly AppDbContext _context;

        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubscribeCreateDto subscribe)
        {
            if (!ModelState.IsValid)
            {
                return View(subscribe);
            }
            Subscribe Ferid = new Subscribe()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                Name = subscribe.Name,
                Email = subscribe.Email,
                Status = false,
            };

            //await _context.Contacts.AddAsync(contact);
            //await _context.SaveChangesAsync();
            await _context.AddAsync(Ferid);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
