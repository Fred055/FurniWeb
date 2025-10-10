namespace FurniWeb.App.Dtos.BasketDtos
{
    public class BasketItemDto
    {
        public Guid FurnitureId { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
