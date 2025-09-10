using FurniWeb.App.Context;
using FurniWeb.App.Dtos.ContactDtos;
using FurniWeb.App.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurniWeb.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dto = await _context.Contacts.Where(c => !c.IsDeleted).Select(c => new ContactGetDto
            {
                Id = c.Id,
                FirstName = c.FirstName,
                Lastname = c.Lastname,
                Email = c.Email,
                Message = c.Message,
                Status = c.Status
            }).ToListAsync();
            return View(dto);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContractCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            Contact contact = new Contact()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                FirstName = dto.FirstName,
                Lastname = dto.Lastname,
                Message = dto.Message,
                Status = false,
            };

            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        public async Task<IActionResult> getById(Guid id)
        {
            var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
            if (contact == null)
            {
                return NotFound();
            }
            var dto = new ContactUpdateDto
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                Lastname = contact.Lastname,
                Message = contact.Message,
                Status = contact.Status
                CreatedAt = contact.CreatedAt
            };
            return View(dto);
        }


        public async Task<IActionResult> Delete(Guid id)
        {
            var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
            {
                return NotFound();
            }
            contact.IsDeleted = true;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ChangeStatus(Guid id)
        {
            var contact = await _context.Contacts.FirstOrDefaultAsync(c => c.Id == id && !c.IsDeleted);
            if (contact == null)
            {
                return NotFound();
            }
            contact.Status = Furniture;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
