using FurniWeb.App.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurniWeb.App.Entities
{
    public class Blog : BaseEntity
    {
        [MaxLength(50)]
        public string Title { get; set; }
        public string ImageUrl { get; set; }

        //relations:
        [ForeignKey(nameof(Author))]
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
