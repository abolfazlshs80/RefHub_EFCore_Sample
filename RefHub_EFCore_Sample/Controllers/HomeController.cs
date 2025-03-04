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


        #region Task1

        public async Task<IActionResult> CreateBook(Book book)
        {
            #region Fill All Record


            book.Title = "test12";
            book.CategoryId = 1;
            book.ISBN = "";
            book.PersonLevelId = 1;
            book.LanguageId = 1;
            book.Quntity = 1;
            book.PublisherName = "";
            book.View = 2;
            book.PublisherYear = "2018";
            book.Price = new Money(1200.50m, "USD");
            #endregion

            await _unitOfWork.BookService.AddAsync(book);
            return View("Index");
        }

        #endregion


        #region Task2

        public async Task<IActionResult> EditBook(Book book)
        {
           
            #region Fill All Record

            book.BookId = 2;
            book.Title = "test12";
            book.CategoryId = 1;
            book.ISBN = "";
            book.PersonLevelId = 1;
            book.LanguageId = 1;
            book.Quntity = 1;
            book.PublisherName = "";
            book.View = 2;
            book.PublisherYear = "2018";
            book.Price = new Money(1200.50m, "USD");
            #endregion

         bool status=   await _unitOfWork.BookService.UpdateAsync(book);
            return View("Index");
        }

        #endregion
        #region Task3


        public async Task<IActionResult> DeleteBook(int bookId = 1)
        {


            bool IsStatus = await _unitOfWork.BookService.DeleteAsync(bookId);
            return View("Index");
        }
        #endregion
        #region Task4


        public async Task<IActionResult> FindBook(int bookId = 2)
        {


            var book = await _unitOfWork.BookService.GetByIdAsync(bookId);
            return View(book);
        }
        #endregion
        #region Task 5


        public async Task<IActionResult> GetNamesBook()
        {


            var book = await _unitOfWork.BookService.GetAllNameBooksAsync();
            return View("Index");
        }
        #endregion

        #region Task 6


        public async Task<IActionResult> GetAllBook()
        {


            var book =  _unitOfWork.BookService.GetAllAsync();
            return View( book);
        }
        #endregion
        public async Task<IActionResult> Index()
        {
  

            return View("GetAllBook", _unitOfWork.BookService.GetAllAsync());
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
