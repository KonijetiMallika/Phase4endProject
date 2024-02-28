namespace Phase4endProject.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int TotalPrice { get; set; }
        public int PizzaId { get; set; }
        public int Price { get; set; }
        public string? Type { get; set; }
        public int Quantity { get; set; }
    }
}
