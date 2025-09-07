using FurniWeb.App.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurniWeb.App.Entities
{
    public class EmployeePosition : BaseEntity
    {
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey("Position")]
        public Guid PositionId { get; set; }
        public Position Position { get; set; }

    }
}
