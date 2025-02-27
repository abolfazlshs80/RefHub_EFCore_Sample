using Microsoft.EntityFrameworkCore;
using RefHub_EFCore_Sample.Database.Context;
using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Service.Implement
{
    public class OrderService : IOrderService
    {
        AppDbContext _context;
        public OrderService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetAllAsync()
        {
            return await _context.Order.ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _context.Order.FindAsync(id);

        }

        public async Task AddAsync(Order Order)
        {
            await _context.Order.AddAsync(Order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Order Order)
        {
            _context.Order.Update(Order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var Order = await _context.Order.FindAsync(id);
            if (Order != null)
            {
                _context.Order.Remove(Order);
                await _context.SaveChangesAsync();
            }
        }
    }
}