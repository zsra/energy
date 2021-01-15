﻿using Energy.Core.Entities.Commerce.Orders;
using Energy.Core.Entities.UserManagement;
using Energy.Core.Extensions.Commerce.CustomTypes;
using Energy.Core.Interfaces.Commerce;
using System;

namespace Energy.Core.Builders.Commerce
{
    public class ShipmentBuilder : IShipmentBuilder
    {
        public Address Address { get; set; }
        public Order Order { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }

        public Shipment GetShipment() => new Shipment(Address, Order, Customer, Payment);
    }
}
