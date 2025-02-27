using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Service
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();

        Task<Category> GetByIdAsync(int id);

        Task AddAsync(Category item);
        Task UpdateAsync(Category item);
        Task DeleteAsync(int id);
    }
}
