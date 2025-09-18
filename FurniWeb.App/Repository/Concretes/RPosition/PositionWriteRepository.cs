using FurniWeb.App.Context;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.R_Position;

namespace FurniWeb.App.Repository.Concretes.RPosition
{
    public class PositionWriteRepository : WriteRepository<Position>, IPositionWriteRepository
    {
        public PositionWriteRepository(AppDbContext context) : base(context)
        {
        }
    }


}
