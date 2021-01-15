using Energy.Core.Entities.UserManagement;
using Energy.Core.Extensions.CustomTypes;

namespace Energy.Core.Entities.Commerce.Orders
{
    public class Shipment : Entity
    {
        public Address Address { get; }
        public Order Order { get; }
        public Customer Customer { get; }
        public Payment Payment { get; }

        public Shipment(Address address, Order order, Customer customer, Payment payment)
        {
            Address = address;
            Order = order;
            Customer = customer;
            Payment = payment;
        }
    }
}
