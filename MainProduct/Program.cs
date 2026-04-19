using System;
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

            //OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            /*Product product = new Product("TV 75 polegadas", 6500.33);
            Product product1 = new Product("Notebook Dell Inspiron", 4000); 
            OrderItem oi = new OrderItem(5, product);
            OrderItem oi1 = new OrderItem(10, product1); 

            Console.WriteLine(oi);
            Console.WriteLine(oi1);*/

            //Console.WriteLine(client);

            Console.Write("How Many Products to buy? "); 
            int n = int.Parse(Console.ReadLine()); 





        }
    }
}
