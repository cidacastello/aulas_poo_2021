using ContaBancaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.depositar(500);
            Console.WriteLine("Saldo: " + conta.Saldo);
            conta.sacar(250);
            Console.WriteLine("Saldo1: " + conta.Saldo);
           // conta.setSaldo(15000000.00);
           // Console.WriteLine("Saldo2: " + conta.getSaldo());

            //Console.WriteLine(conta.saldo);
            //Conta conta2 = new Conta("Jon Snow", 2536, 200);

            Console.ReadKey();
        }
    }
   
}
