using Microsoft.EntityFrameworkCore;
using RefHub_EFCore_Sample.Database.Context;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Service.Implement
{
    public class BookService : IBookService
    {
        AppDbContext _context;
        public BookService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Book.ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _context.Book.FindAsync(id);

        }

        public async Task AddAsync(Book Book)
        {
            await _context.Book.AddAsync(Book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Book Book)
        {
            _context.Book.Update(Book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var Book = await _context.Book.FindAsync(id);
            if (Book != null)
            {
                _context.Book.Remove(Book);
                await _context.SaveChangesAsync();
            }
        }
    }
}