using FurniWeb.App.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace FurniWeb.App.Repository.Abstracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
