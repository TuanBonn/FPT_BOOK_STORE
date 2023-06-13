using System.ComponentModel.DataAnnotations;

namespace FPT_BOOK_STORE.Models
{
    public class Category
    {
        [Key] public int Category_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }
    }
}
