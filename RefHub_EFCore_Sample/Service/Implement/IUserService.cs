using Microsoft.EntityFrameworkCore;
using RefHub_EFCore_Sample.Database.Context;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Service.Implement
{
    public class UserService : IUserService
    {
        AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);

        }

        public async Task AddAsync(User User)
        {
            await _context.Users.AddAsync(User);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User User)
        {
            _context.Users.Update(User);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var User = await _context.Users.FindAsync(id);
            if (User != null)
            {
                _context.Users.Remove(User);
                await _context.SaveChangesAsync();
            }
        }
    }
}