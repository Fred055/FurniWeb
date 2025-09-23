using FurniWeb.App.Context;

namespace FurniWeb.App.Repository.Concretes.RFurniture
{
    public class FurnitureWriteRepository : WriteRepository<Entities.Furniture>, Abstracts.RFurniture.IFurnitureWriteRepository
    {
        public FurnitureWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
