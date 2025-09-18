using FurniWeb.App.Entities.BaseEntities;
using System.Linq.Expressions;

namespace FurniWeb.App.Repository.Abstracts
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> FilterAll(Expression<Func<T, bool>> filter);
        Task<T?> GetByIdAsync(Guid id);
        Task<T> FilterFirstAsync(Expression<Func<T, bool>> filter);
    }
}
