using FurniWeb.App.Context;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.REmployee;

namespace FurniWeb.App.Repository.Concretes.REmployee
{
    public class EmployeeReadRepository : ReadRepository<Employee>, IEmployeeReadRepository
    {
        public EmployeeReadRepository(AppDbContext context) : base(context)
        {
        }
    }


}
