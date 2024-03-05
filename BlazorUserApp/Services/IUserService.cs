using BlazorUserApp.Data;

namespace BlazorUserApp.Services
{
    public interface IUserService
    {
        Task<List<Users>> GetUsers();
        Task<Users> GetUser(int id);
        Task AddUser(Users user);
        Task UpdateUser(Users user);
        Task DeleteUser(int id);


    }
}
