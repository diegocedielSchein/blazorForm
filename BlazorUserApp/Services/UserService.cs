
using BlazorUserApp.Data;
using Microsoft.EntityFrameworkCore;
namespace BlazorUserApp.Services
{
    public class UserService : IUserService
    {

        private readonly UserDbContext _dbContext;
        public UserService(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Users>> GetUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<Users> GetUser(int id)
        {
            return await _dbContext.Users.FindAsync(id);
        }

        public async Task AddUser(Users user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUser(Users user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();
            }

        }
    }
}
