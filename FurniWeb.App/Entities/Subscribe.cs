using FurniWeb.App.Entities.BaseEntities;

namespace FurniWeb.App.Entities
{
    public class Subscribe : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}
