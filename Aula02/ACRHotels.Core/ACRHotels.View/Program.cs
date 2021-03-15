using System;
using ACRHotels.Domain;

namespace ACRHotels.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cliente cliente = new Cliente();
            cliente.Nome = "Cida";
            Console.WriteLine(cliente.Nome);

            Console.ReadKey();
            
        }
    }
}
