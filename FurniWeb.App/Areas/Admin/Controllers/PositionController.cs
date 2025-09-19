using BabatMebel.App.Dtos.PositionDtos;

using FurniWeb.App.Dtos.PositionDtos;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.R_Position;
using FurniWeb.App.Repository.Concretes.RPosition;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BabatMebel.App.Areas.Admin.Controllers
{
    [Area("admin")]
    public class PositionController : Controller
    {
        private readonly IPositionWriteRepository _positionWrite;
        private readonly IPositionReadRepository _positionRead;

        public PositionController(IPositionWriteRepository positionWrite, PositionReadRepository positionRead)
        {
            _positionWrite = positionWrite;
            _positionRead = positionRead;
        }

        public async Task<IActionResult> Index()
        {
            var positions = await _positionRead.FilterAll(p => !p.IsDeleted).Select(c => new PositionGetDto
            {
                Id = c.Id,
                Name = c.Name,
            }).ToListAsync();

            return View(positions);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PositionCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            var position = new Position
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                Name = dto.Name,
            };

            await _positionWrite.AddAsync(position);
            await _positionWrite.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(Guid id)
        {
            var position = await _positionRead.FilterFirstAsync(p => p.Id == id && !p.IsDeleted);

            if (position == null) return NotFound();

            var dto = new PositionUpdateDto
            {
                Id = position.Id,
                Name = position.Name,
            };

            return View(dto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(PositionUpdateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }

            var position = await _positionRead.FilterFirstAsync(p => p.Id == dto.Id && !p.IsDeleted);

            if (position == null) return NotFound();

            position.Name = dto.Name;
            position.UpdatedAt = DateTime.Now;

            _positionWrite.Update(position);
            await _positionWrite.SaveAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}