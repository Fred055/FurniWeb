using FurniWeb.App.Context;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.RBasket;

namespace FurniWeb.App.Repository.Concretes.RBasket
{
    public class BasketWriteRepository : WriteRepository<Basket>, IBasketWriteRepository
    {
        public BasketWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
