using System;
using System.Linq;
using System.Collections.Generic;
using ordering_service.Entities.Enums;

namespace ordering_service.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item) => OrderItems.Add(item);
        public bool RemoveItem(OrderItem item) => OrderItems.Remove(item);
        public double Total() => OrderItems.Sum(item => item.Price);
    }
}