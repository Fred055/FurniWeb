using FurniWeb.App.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace FurniWeb.App.Entities
{
    public class Service : BaseEntity
    {
        public string Icon { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public decimal Description { get; set; }

    }
}
