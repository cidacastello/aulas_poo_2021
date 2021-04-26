using System;
using FolhaPagamento.Entities;
namespace FolhaPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado empregado = new Empregado("Jon Snow", 1000);
            Console.WriteLine("{0} = {1}", empregado.Nome, empregado.CalcularPagamento());

            Comissionado comissionado = new Comissionado("Cersei", 1000, 500);
            Console.WriteLine("{0} = {1}", comissionado.Nome, comissionado.CalcularPagamento());

            Console.ReadKey();
        }
    }
}
