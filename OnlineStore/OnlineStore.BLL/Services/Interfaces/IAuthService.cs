using OnlineStore.BLL.Models;

namespace OnlineStore.BLL.Services.Interfaces
{
    public interface IAuthService
    {
        Task<UserModel> Register(UserModel user);
        Task<string> Login(UserModel user);
        string GetEmailFromJwtToken(string token);
    }
}