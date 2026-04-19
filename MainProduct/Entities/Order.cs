using System;
using System.Collections.Generic;
using System.Text;
using MainProduct.Entities.Enums; 

namespace MainProduct.Entities
{
    internal class Order
    {
        public DateTime date { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> OrderItens { get; private set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
            this.date = DateTime.Now;
        }

        public Order(OrderStatus orderStatus) : this()
        {
            OrderStatus = orderStatus;
        }

        public Order(OrderStatus orderStatus, Client client) : this(orderStatus)
        {
            this.Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item); 
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0; 
            foreach(OrderItem o in OrderItens)
            {
                sum += o.subTotal();
            }
            return sum; 
        }
    }
}
