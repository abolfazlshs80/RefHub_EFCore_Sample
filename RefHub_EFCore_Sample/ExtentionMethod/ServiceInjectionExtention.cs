
    using RefHub_EFCore_Sample.Service;
    using RefHub_EFCore_Sample.Service.Implement;

    public static class ServiceInjectionExtention
    {
        public static void AddDependencyInjectionDatabaseService(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }

