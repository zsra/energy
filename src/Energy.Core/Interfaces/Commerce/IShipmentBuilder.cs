using Energy.Core.Entities.Commerce.Orders;
using Energy.Core.Entities.UserManagement;
using Energy.Core.Extensions.Commerce.CustomTypes;

namespace Energy.Core.Interfaces.Commerce
{
    public interface IShipmentBuilder
    {
        public Address Address { get; set; }
        public Order Order { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }

        public Shipment GetShipment();
    }
}
