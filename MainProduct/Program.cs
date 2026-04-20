using System;
using System.Globalization;
using MainProduct.Entities;
using MainProduct.Entities.Enums;

namespace MainProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o nome do cliente: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Informe data de nascimento (DD / MM / YYYY): "); 
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            Console.Write("Quantos produtos para comprar? "); 
            int n = int.Parse(Console.ReadLine());
            Console.Write("Order Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order newOrder = new Order(orderStatus, client);

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Informe dados do {i}º produto: \n");
                Console.Write("Nome: " );
                string nameProduct = Console.ReadLine();
                Console.Write("Quantidade: "); 
                int quantity = int.Parse(Console.ReadLine());
                Console.Write("Preço $"); 
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Product p = new Product(nameProduct, price);
                OrderItem o = new OrderItem(quantity, p);
                newOrder.AddItem(o); 
            }

            Console.WriteLine(newOrder);

        }
    }
}
