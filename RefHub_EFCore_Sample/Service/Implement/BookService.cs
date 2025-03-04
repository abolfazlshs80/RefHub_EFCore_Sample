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
        public IQueryable<Book> GetAllAsync()
        {
            return _context.Book;
        }

        public async Task<List<string>> GetAllNameBooksAsync()
        {
            return await _context.Book.Select(a=>a.Title).ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _context.Book.FindAsync(id);

        }
        public async Task<Book> GetByNameAsync(string Name)
        {
            return await _context.Book.Where(a => a.Title.Equals(Name)).FirstOrDefaultAsync();

        }
        public async Task<bool> IsExistsBook(string title)
        {
            return await _context.Book.AnyAsync(a => a.Title.Equals(title));

        }
        public async Task AddAsync(Book Book)
        {
            var newbook = await GetByNameAsync(Book.Title);
            if (newbook != null)
            {
                newbook.Quntity = newbook.Quntity + 1;
                _context.Update(newbook);
                //         await _context.Book.ExecuteUpdateAsync(a=>a.SetProperty(a=>a.Quntity, newbook.Quntity+1));
            }

            else
                await _context.Book.AddAsync(Book);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(Book book)
        {
            try
            {
                var newbook = await GetByIdAsync(book.BookId);
                if (newbook != null)
                {
                    #region Fill All Record

                    newbook.BookId = book.BookId;
                    newbook.Title = book.Title;
                    newbook.CategoryId = book.CategoryId;
                    newbook.ISBN = book.ISBN;
                    newbook.PersonLevelId = book.PersonLevelId;
                    newbook.LanguageId = book.LanguageId;
                    newbook.Quntity = book.Quntity;
                    newbook.PublisherName = book.PublisherName;
                    newbook.View = book.View;
                    newbook.PublisherYear = book.PublisherYear;
                    newbook.Price = book.Price;
                    #endregion

                    _context.Book.Update(newbook);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch { }

            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var Book = await _context.Book.FindAsync(id);
            if (Book != null)
            {
                _context.Book.Remove(Book);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}