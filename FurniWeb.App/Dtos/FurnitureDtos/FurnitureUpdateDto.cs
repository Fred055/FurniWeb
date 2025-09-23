namespace FurniWeb.App.Dtos.FurnitureDtos
{
    public class FurnitureUpdateDto
    {
        public string? Image { get; set; }
        public IFormFile ImageUpload { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
    }
}
