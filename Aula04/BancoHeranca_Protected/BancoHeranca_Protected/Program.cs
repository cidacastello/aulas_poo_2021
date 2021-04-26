using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoHeranca_Protected.Entities;
namespace BancoHeranca_Protected
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEmpresarial empresarial = new ContaEmpresarial();
            empresarial.Depositar(1000);
            Console.WriteLine("Saldo: " + empresarial.Saldo);
            empresarial.Sacar(100);
            Console.WriteLine("Saldo: " + empresarial.Saldo);

            Console.ReadKey();
        }
    }
}
