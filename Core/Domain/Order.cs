using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class Order
    {
        public Guid OrderId { get; protected set; }
        public User User { get; protected set; }
        public Event Eevent { get; protected set; }
        public decimal OrderCost { get; protected set; }

    }
}
