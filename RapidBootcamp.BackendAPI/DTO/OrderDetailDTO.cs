namespace RapidBootcamp.BackendAPI.DTO
{
    public class OrderDetailDTO
    {
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int Qty { get; set; }
        public decimal Price { get; set; }
    }
}
