using WebShop.Core.Enums;

namespace WebShop.Core.Entities
{
    public class PaymentInfo
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string Expiration { get; set; }
        public string CVV { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}