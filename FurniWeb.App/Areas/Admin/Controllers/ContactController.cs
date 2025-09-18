using FurniWeb.App.Dtos.ContactDtos;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.RContact;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FurniWeb.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactReadRepository _contactRead;
        private readonly IContactWriteRepository _contactWrite;


        public ContactController(IContactReadRepository contactRead, IContactWriteRepository contactWrite)
        {
            _contactRead = contactRead;
            _contactWrite = contactWrite;
        }

        public async Task<IActionResult> Index()
        {
            var dto = await _contactRead.FilterAll(c => !c.IsDeleted).Select(c => new ContactGetDto
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
        public async Task<IActionResult> Create(ContactCreateDto dto)
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
                Email = dto.Email,
                Message = dto.Message,
                Status = false,
            };

            //await _context.Contacts.AddAsync(contact);
            //await _context.SaveChangesAsync();
            await _contactWrite.AddAsync(contact);
            await _contactWrite.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> getById(Guid id)
        {
            var contact = await _contactRead.FilterFirstAsync(c => c.Id == id && !c.IsDeleted);
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
                Status = contact.Status,
                CreatedAt = contact.CreatedAt
            };
            return View(dto);
        }


        public async Task<IActionResult> Delete(Guid id)
        {
            var contact = await _contactRead.FilterFirstAsync(c => c.Id == id && !c.IsDeleted);
            if (contact == null)
            {
                return NotFound();
            }
            contact.IsDeleted = true;

            await _contactWrite.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ChangeStatus(Guid id)
        {
            var contact = await _contactRead.FilterFirstAsync(c => c.Id == id && !c.IsDeleted);
            if (contact == null)
            {
                return NotFound();
            }
            //contact.Status = true;
            //await _context.SaveChangesAsync();

            contact.Status = true;
            await _contactWrite.SaveAsync();

            return RedirectToAction(nameof(Index));


        }

        public async Task<IActionResult> ReverseStatus(Guid id)
        {
            var contact = await _contactRead.FilterFirstAsync(c => c.Id == id && !c.IsDeleted);
            if (contact == null)
            {
                return NotFound();
            }
            //contact.Status = false;
            //await _context.SaveChangesAsync();

            contact.Status = false;
            await _contactWrite.SaveAsync();

            return RedirectToAction(nameof(Index));
        }


    }
}
