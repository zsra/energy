using Energy.Core.Entities.Commerce.Orders;
using Energy.Core.Entities.UserManagement;
using Energy.Core.Extensions.CustomTypes;
using Energy.Core.Interfaces.Extensions;

namespace Energy.Core.Directors
{
    public class ShipmentBuildDirector
    {
        private IShipmentBuilder _builder;

        public ShipmentBuildDirector(IShipmentBuilder builder) => _builder = builder;

        public void AddAddress(Address address) => _builder.Address = address;
        public void AddOrder(Order order) => _builder.Order = order;
        public void AddCustomer(Customer customer) => _builder.Customer = customer;
        public void AddPayment(Payment payment) => _builder.Payment = payment;
    }
}
