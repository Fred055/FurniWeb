using FurniWeb.App.Context;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.RBasketItem;

namespace FurniWeb.App.Repository.Concretes.RBasketItem
{
    public class BasketItemWriteRepository : WriteRepository<BasketItem>, IBasketItemWriteRepository
    {
        public BasketItemWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
