using Energy.Core.Entities.UserManagement;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Energy.Core.Entities.Orders
{
    public class Basket : Entity
    {
        public Customer Customer { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; } = new Collection<BasketItem>();
    }
}
