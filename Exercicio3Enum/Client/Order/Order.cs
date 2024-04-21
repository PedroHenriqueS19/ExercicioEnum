using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio3Enum.Client.Order.OrderStatus;
using Exercicio3Enum.Client;
using Exercicio3Enum.Client.Order.OrderItem.Product;
using Exercicio3Enum.Client.Order.OrderItem;

namespace Exercicio3Enum.Client.Order
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatuss Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItems> Items { get; set; } = new List<OrderItems>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatuss status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItems items) { Items.Add(items); }
        public void RemoveItem(OrderItems items) { Items.Remove(items); }
        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItems items in Items)
            {
                sum += items.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"{Client}");
            sb.AppendLine($"Order items: ");
            foreach(OrderItems items in Items)
            {
                sb.AppendLine(items.ToString());
            }
            sb.AppendLine($"$Total price: {Total():f2}");
            return sb.ToString();
        }
        
    }
}
