using Energy.Core.Entities.Orders;
using Energy.Core.Entities.UserManagement;
using Energy.Core.Interfaces.Extensions;

namespace Energy.Core.Extensions.Directors
{
    public class OrderBuildDirector
    {
        private readonly IOrderBuilder _builder;
        
        public OrderBuildDirector(IOrderBuilder builder) => _builder = builder;

        public void AddBasket(Basket basket) => _builder.Basket = basket;
        public void AddCustomer(Customer customer) => _builder.Customer = customer;
        public void AddShipment(Shipment shipment) => _builder.Shipment = shipment;
        public void AddPayment(Payment payment) => _builder.Payment = payment;
    }
}
