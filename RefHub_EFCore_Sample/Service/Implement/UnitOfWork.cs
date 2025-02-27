using RefHub_EFCore_Sample.Database.Context;

namespace RefHub_EFCore_Sample.Service.Implement
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public ICategoryService CategoryService { get; private set; }
        public IBookService BookService { get; private set; }
        public IOrderService OrderService { get; private set; }
        public IUserService UserService { get; private set; }


        public UnitOfWork(AppDbContext context, ICategoryService _categoryService,IBookService _bookService, IOrderService orderService, IUserService userService)
        {
            _context = context;
            CategoryService = _categoryService;
            BookService = _bookService;
            OrderService = orderService;
            UserService = userService;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
