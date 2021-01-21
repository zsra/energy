using Energy.Core.Entities.Orders;
using Energy.Core.Entities.UserManagement;
using Energy.Core.Interfaces.Extensions;

namespace Energy.Core.Extensions.Builder
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
