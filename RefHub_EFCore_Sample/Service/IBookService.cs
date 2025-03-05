using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Service
{
    public interface IBookService
    {
        IQueryable<Book> GetAllByPagination(out int count, int Take = 4, int Page = 0);
        IQueryable<Book> GetAllAsync();
        Task<Book> GetByNameAsync(string Name);
        Task<List<string>> GetAllNameBooksAsync();
        Task<Book> GetByIdAsync(int id);
         Task<bool> IsExistsBook(string title);
        Task AddAsync(Book item);
        Task<bool> UpdateAsync(Book item);
        Task<bool> DeleteAsync(int id);
    }
}
