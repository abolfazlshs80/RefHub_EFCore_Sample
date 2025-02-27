using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RefHub_EFCore_Sample.Database.Model;
using RefHub_EFCore_Sample.Exception;
using RefHub_EFCore_Sample.Models;
using RefHub_EFCore_Sample.Service;

namespace RefHub_EFCore_Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                //await _unitOfWork.BookService.AddAsync(new Book()
                //{
                    
                //    CategoryId = 1,
                //    ISBN = "",
                //    PersonLevelId = 1,
                //    LanguageId = 1,
                //    PublisherName = "",
                //    View = 2,
                //    PublisherYear = "2018",
                //    Price = new Money(1200.50m, "USD")
                //});

                //await _unitOfWork.OrderService.AddAsync(new Order()
                //{
                //    UserId = 1,
                //    Count = 2,
                //    UserIdAddress = 2,
                    
                //    TotalPrice = 1000,
                //    Status = OrderStatus.Pending
                //});
                //await _unitOfWork.UserService.AddAsync(
                //new User()
                //{
                //     UserName = "User", Name = "User", Family = "_User", Email = "User@localhost.com", Password = "123" ,
                //    Attributes = new Dictionary<string, string>
                //    {
                //        { "Color", "Silver" },
                //        { "Weight", "2.5kg" },
                //        { "Storage", "512GB SSD" }
                //    }

                //});
            }
            catch (ValidateModelException ex)
            {
                
                Console.WriteLine(ex); 
            }
            var category = await _unitOfWork.CategoryService.GetAllAsync();

            var order = await _unitOfWork.UserService.GetByIdAsync(3);
            
            //   await _unitOfWork.CategoryService.UpdateAsync(category?.FirstOrDefault());
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
