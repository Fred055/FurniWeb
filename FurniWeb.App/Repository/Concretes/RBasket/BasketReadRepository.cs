using FurniWeb.App.Context;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.RBasket;

namespace FurniWeb.App.Repository.Concretes.RBasket
{
    public class BasketReadRepository : ReadRepository<Basket>, IBasketReadRepository
    {
        public BasketReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
