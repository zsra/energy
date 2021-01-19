using Energy.Core.Entities.UserManagement;

namespace Energy.Core.Entities.Orders
{
    public class Order : Entity
    {
        public Basket Basket { get; }
        public Customer Customer { get; }
        public Shipment Shipment { get; }
        public Payment Payment { get; }

        public Order(Basket basket, Customer customer, Shipment shipment, Payment payment)
        {
            Basket = basket;
            Customer = customer;
            Shipment = shipment;
            Payment = payment;
        }
    }
}
