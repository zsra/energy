using Energy.Core.Entities.Commerce.Orders;
using Energy.Core.Entities.UserManagement;
using Energy.Core.Interfaces.Commerce;

namespace Energy.Core.Builder.Commerce
{
    public class OrderBuilder : IOrderBuilder
    {
        public Basket Basket { get; set; }
        public Customer Customer { get; set; }
        public Shipment Shipment { get; set; }
        public Payment Payment { get; set; }

        public Order GetOrder() => new Order(Basket, Customer, Shipment, Payment);
    }
}
