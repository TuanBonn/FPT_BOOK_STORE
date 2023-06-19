using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPT_BOOK_STORE.Models
{
    [Table("Book")]
    public class Book
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }   
        public double Price { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }
        [NotMapped] public string CategoryName { get; set; }
    }
}
