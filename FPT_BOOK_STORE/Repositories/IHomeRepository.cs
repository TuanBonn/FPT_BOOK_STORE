using FPT_BOOK_STORE.Models;
using Humanizer.Localisation;

namespace FPT_BOOK_STORE.Repositories
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Book>> GetBooks(string sTerm = "", int genreId = 0);
        Task<IEnumerable<Category>> Categories();
    }
}