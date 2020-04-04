namespace WebShop.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }

        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }

        public int PaymentInfoId { get; set; }
        public PaymentInfo PaymentInfo { get; set; }
    }
}
