using Energy.Core.Entities.Commerce.Orders;
using Energy.Core.Entities.UserManagement;

namespace Energy.Core.Interfaces.Commerce
{
    public interface IOrderBuilder
    {
        public Basket Basket { get; set; }
        public Customer Customer { get; set; }
        public Shipment Shipment { get; set; }
        public Payment Payment { get; set; }

        public Order GetOrder();
    }
}
