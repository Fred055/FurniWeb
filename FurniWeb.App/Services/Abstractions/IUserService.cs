namespace FurniWeb.App.Services.Abstractions
{
    public interface IUserService
    {
        public Task<string> FindUser(string userName);
    }
}
