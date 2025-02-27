using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Service
{
    public interface IUserService
    {
        Task<List<User>> GetAllAsync();

        Task<User> GetByIdAsync(int id);

        Task AddAsync(User item);
        Task UpdateAsync(User item);
        Task DeleteAsync(int id);
    }
}
