using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPT_BOOK_STORE.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        [Key] public int Id { get; set; }
        public int StatusId { get; set; }
        public string? StatusName { get; set; }
    }
}
