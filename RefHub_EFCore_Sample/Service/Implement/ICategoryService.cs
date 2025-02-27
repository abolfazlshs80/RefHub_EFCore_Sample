using Microsoft.EntityFrameworkCore;
using RefHub_EFCore_Sample.Database.Context;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Service.Implement
{
    public class CategoryService : ICategoryService
    {
        AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Category.FindAsync(id);

        }

        public async Task AddAsync(Category category)
        {
            await _context.Category.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            _context.Category.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category != null)
            {
                _context.Category.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}