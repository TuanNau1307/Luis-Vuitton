namespace NowSaiGon.Models
{
    public class CartItem
    {
        public int proId { get; set; }
        public string proName { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalMoney => Price * Quantity;
    }
}
