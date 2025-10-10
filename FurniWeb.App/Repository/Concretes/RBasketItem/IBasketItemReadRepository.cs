using FurniWeb.App.Context;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.RBasketItem;

namespace FurniWeb.App.Repository.Concretes.RBasketItem
{
    public class BasketItemReadRepository : ReadRepository<BasketItem>, IBasketItemReadRepository
    {
        public BasketItemReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
