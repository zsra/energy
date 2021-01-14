using Energy.Core.Entities.UserManagement;

namespace Energy.Core.Entities.Commerce.Orders
{
    public class Order : Entity
    {
        public Basket Basket { get; set; }
        public Customer Customer { get; set; }
        public Shipment Shipment { get; set; }
        public Payment Payment { get; set; }

        public Order(Basket basket, Customer customer, Shipment shipment, Payment payment)
        {
            Basket = basket;
            Customer = customer;
            Shipment = shipment;
            Payment = payment;
        }
    }
}
