using FurniWeb.App.Entities;
using FurniWeb.App.Services.Abstractions;
using Microsoft.AspNetCore.Identity;

namespace FurniWeb.App.Services.Concretes
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<string> FindUser(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            return user.UserName;
        }


    }
}
