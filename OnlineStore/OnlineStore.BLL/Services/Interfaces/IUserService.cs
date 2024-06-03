using OnlineStore.BLL.Models;

namespace OnlineStore.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserModel?> GetUserByEmail(string email);
    }
}