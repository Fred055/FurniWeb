using FurniWeb.App.Dtos.BasketDtos;

namespace FurniWeb.App.Services.Abstractions
{
    public interface IBasketService
    {
        public Task<string> AddBasket(Guid id);
        public Task<List<BasketItemDto>> GetAllBasket();
        public Task Remove(Guid id);
    }
}
