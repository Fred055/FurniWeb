namespace FurniWeb.App.Dtos.Subscribe
{
    public class SubscribeGetDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public bool Status { get; set; }
    }
}
