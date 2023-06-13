using System.ComponentModel.DataAnnotations;

namespace FPT_BOOK_STORE.Models
{
    public class Book
    {
        [Key] public int Book_Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public DateTime Release_date { get; set; }
        public Category Category { get; set; }
    }
}
