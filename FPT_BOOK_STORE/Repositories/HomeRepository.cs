using FPT_BOOK_STORE.Data;
using FPT_BOOK_STORE.Models;
using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;

namespace FPT_BOOK_STORE.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly FPT_BOOK_STOREContext _db;

        public HomeRepository(FPT_BOOK_STOREContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Category>> Categories()
        {
            return await _db.Categories.ToListAsync();
        }
        public async Task<IEnumerable<Book>> GetBooks(string sTerm = "", int genreId = 0)
        {
            sTerm = sTerm.ToLower();
            IEnumerable<Book> books = await (from book in _db.Books
                                             join category in _db.Categories  
                                             on book.CategoryId equals category.Id
                                             where string.IsNullOrWhiteSpace(sTerm) || (book != null && book.Name.ToLower().StartsWith(sTerm))
                                             select new Book
                                             {
                                                 Id = book.Id,
                                                 Name = book.Name,
                                                 Image = book.Image,
                                                 Price = book.Price,
                                                 Publisher = book.Publisher,
                                                 Author = book.Author,
                                                 ReleaseDate = book.ReleaseDate,
                                                 CategoryId = book.CategoryId,
                                                 CategoryName = book.CategoryName,
                                             }
                         ).ToListAsync();
            if (genreId > 0)
            {

                books = books.Where(a => a.CategoryId == genreId).ToList();
            }
            return books;

        }
    }
}