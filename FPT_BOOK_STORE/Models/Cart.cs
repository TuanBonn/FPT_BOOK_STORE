using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPT_BOOK_STORE.Models
{
    [Table("Cart")]
    public class Cart
    {
        [Key] public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
