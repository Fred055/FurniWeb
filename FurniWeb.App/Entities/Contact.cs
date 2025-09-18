using FurniWeb.App.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace FurniWeb.App.Entities
{
    public class Contact : BaseEntity
    {
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string Lastname { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}
