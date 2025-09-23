using FurniWeb.App.Dtos.ContactDtos;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.RContact;
using Microsoft.AspNetCore.Mvc;

namespace FurniWeb.App.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactReadRepository _contactRead;
        private readonly IContactWriteRepository _contactWrite;
        public ContactController(IContactReadRepository contactRead, IContactWriteRepository contactWrite)
        {
            _contactRead = contactRead;
            _contactWrite = contactWrite;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Post([FromBody] ContactCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            var contact = new Contact
            {
                Id = Guid.NewGuid(),
                Email = dto.Email,
                CreatedAt = DateTime.Now,
                FirstName = dto.FirstName,
                Lastname = dto.Lastname,
                Message = dto.Message,
                Status = false,
            };

            await _contactWrite.AddAsync(contact);
            await _contactWrite.SaveAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
