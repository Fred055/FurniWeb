using FurniWeb.App.Context;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.R_Position;

namespace FurniWeb.App.Repository.Concretes.RPosition
{
    public class PositionReadRepository : ReadRepository<Position>, IPositionReadRepository
    {
        public PositionReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
