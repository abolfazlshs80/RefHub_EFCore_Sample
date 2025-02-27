using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Service
{
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync();

        Task<Book> GetByIdAsync(int id);

        Task AddAsync(Book item);
        Task UpdateAsync(Book item);
        Task DeleteAsync(int id);
    }
}
