using FurniWeb.App.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace FurniWeb.App.Entities
{
    public class Author : BaseEntity
    {
        [MaxLength(30)]
        public string FullName { get; set; }
        public ICollection<Blog> Blogs { get; set; } = new List<Blog>();
    }
}
