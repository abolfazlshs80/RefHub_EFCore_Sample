using RefHub_EFCore_Sample.Database.Model;

namespace RefHub_EFCore_Sample.Service
{
    public interface IOrderService
    {
        Task<List<Order>> GetAllAsync();

        Task<Order> GetByIdAsync(int id);

        Task AddAsync(Order item);
        Task UpdateAsync(Order item);
        Task DeleteAsync(int id);
    }
}
