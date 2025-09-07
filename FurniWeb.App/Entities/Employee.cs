using FurniWeb.App.Entities.BaseEntities;

namespace FurniWeb.App.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }

        //Relations
        public ICollection<EmployeePosition> Positions { get; set; } = new List<EmployeePosition>();
    }
}
