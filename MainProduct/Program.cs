using System;
using MainProduct.Entities; 

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

            //Console.WriteLine(client);

        }
    }
}
