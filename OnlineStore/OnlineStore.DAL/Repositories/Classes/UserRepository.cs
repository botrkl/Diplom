using OnlineStore.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.Context;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.Repositories.Classes
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataBaseContext context) : base(context)
        {
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            return await DbSet.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}