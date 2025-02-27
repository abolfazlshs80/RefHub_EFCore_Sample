namespace RefHub_EFCore_Sample.Service
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryService CategoryService { get; }
        IBookService BookService { get; }
        IOrderService OrderService { get; }
        IUserService UserService { get; }

    
        Task<int> CompleteAsync();
    }
}
