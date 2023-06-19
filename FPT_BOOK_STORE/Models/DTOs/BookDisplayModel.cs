using Humanizer.Localisation;

namespace FPT_BOOK_STORE.Models.DTOs
{
    public class BookDisplayModel
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Temp { get; set; } = "";
        public int CategoryId { get; set; } = 0;
    }
}
