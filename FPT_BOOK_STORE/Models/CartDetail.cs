using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPT_BOOK_STORE.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        [Key] public int Id { get; set; }
        public int CartId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public Book book { get; set; }
        public Cart Cart { get; set; }
    }
}
