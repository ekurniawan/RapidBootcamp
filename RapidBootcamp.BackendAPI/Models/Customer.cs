using System.ComponentModel.DataAnnotations;

namespace RapidBootcamp.BackendAPI.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Email { get; set; }

        public IEnumerable<OrderHeader>? OrderHeaders { get; set; }
    }
}
