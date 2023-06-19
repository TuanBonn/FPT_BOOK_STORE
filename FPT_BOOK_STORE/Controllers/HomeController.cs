using FPT_BOOK_STORE.Repositories;
using FPT_BOOK_STORE.Models;
using FPT_BOOK_STORE.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FPT_BOOK_STORE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;

        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string temp="", int categoryId = 0)
        {
            IEnumerable<Book> books = await _homeRepository.GetBooks(temp, categoryId);
            IEnumerable<Category> categories = await _homeRepository.Categories();
            BookDisplayModel bookModel = new()
            {
                Books = books,
                Categories = categories,
                Temp = temp,
                CategoryId = categoryId
            };

            return View(bookModel);
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