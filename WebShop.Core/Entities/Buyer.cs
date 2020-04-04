using System.Collections.Generic;

namespace WebShop.Core.Entities
{
    public class Buyer
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}