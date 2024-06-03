namespace OnlineStore.BLL.Services.Interfaces
{
    public interface IHashService
    {
        string HashPassword(string password);
        bool VerifyPassword(string enteredPassword, string savedPasswordHash);
    }
}