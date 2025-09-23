using FurniWeb.App.Context;
using FurniWeb.App.Repository.Abstracts.RFurniture;

namespace FurniWeb.App.Repository.Concretes.RFurniture
{
    public class FurnitureReadRepository : ReadRepository<Entities.Furniture>, IFurnitureReadRepository
    {
        public FurnitureReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
