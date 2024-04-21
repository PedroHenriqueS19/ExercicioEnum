using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio3Enum.Client.Order.OrderItem.Product;
namespace Exercicio3Enum.Client.Order.OrderItem
{
     class OrderItems
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Products Product { get; set; }

        public OrderItems()
        {
        }

        public OrderItems(int quantity, double price, Products product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return $"{Product.Name}, ${Price:f2}, Quantity: {Quantity}, Subtotal: ${SubTotal():f2}";
        }
    }
}
