using Exercicio3Enum.Client.Order.OrderStatus;
using Exercicio3Enum.Client;
using Exercicio3Enum.Client.Order.OrderItem.Product;
using Exercicio3Enum.Client.Order.OrderItem;
using Exercicio3Enum.Client.Order;

            Console.WriteLine($"Enter client data: ");
            Console.Write($"Name: ");
            string clientName = Console.ReadLine();
            Console.Write($"Email: ");
            string email = Console.ReadLine();
            Console.Write($"Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(clientName, email, birthDate);
            Console.WriteLine($"Enter order data: ");
            Console.Write($"Status: ");
            OrderStatuss status = Enum.Parse<OrderStatuss>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);
            Console.Write($"How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write($"Product name: ");
                string productName = Console.ReadLine();
                Console.Write($"Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write($"Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Products products = new Products(productName, price);
                OrderItems orderItems = new OrderItems(quantity, price, products);
                order.AddItem(orderItems);
            }
            Console.WriteLine();
            Console.WriteLine($"Order Summary:");
            Console.WriteLine(order);
