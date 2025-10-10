using FurniWeb.App.Context;
using FurniWeb.App.Dtos.Subscribe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurniWeb.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscribeController : Controller
    {
        private readonly AppDbContext _context;
        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var subscribe = await _context.Subscribe.Select(s => new SubscribeGetDto
            {
                Id = s.Id,
                Email = s.Email,
                Name = s.Name,
                Status = s.Status
            }).ToListAsync();
            return View(subscribe);
        }


    }
}
