using FurniWeb.App.Entities.BaseEntities;

namespace FurniWeb.App.Entities
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<EmployeePosition> Employees { get; set; } = new List<EmployeePosition>();
    }
}
