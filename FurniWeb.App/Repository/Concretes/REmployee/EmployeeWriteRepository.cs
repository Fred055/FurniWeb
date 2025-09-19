using FurniWeb.App.Context;
using FurniWeb.App.Entities;
using FurniWeb.App.Repository.Abstracts.REmployee;

namespace FurniWeb.App.Repository.Concretes.REmployee
{
    public class EmployeeWriteRepository : WriteRepository<Employee>, IEmployeeWriteRepository
    {
        public EmployeeWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
