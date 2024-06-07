namespace RapidBootcamp.WebApplication.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Email { get; set; }

        public IEnumerable<OrderHeader>? OrderHeaders { get; set; }
    }
}
