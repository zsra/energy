using Energy.Core.Entities.Commerce.Orders;
using Energy.Core.Entities.UserManagement;
using Energy.Core.Interfaces.Commerce;

namespace Energy.Core.Extensions.Directors
{
    public class OrderBuildDirector
    {
        private IOrderBuilder _builder;
        
        public OrderBuildDirector(IOrderBuilder builder) => _builder = builder;

        public void AddBasket(Basket basket) => _builder.Basket = basket;
        public void AddCustomer(Customer customer) => _builder.Customer = customer;
        public void AddShipment(Shipment shipment) => _builder.Shipment = shipment;
        public void AddPayment(Payment payment) => _builder.Payment = payment;
    }
}
