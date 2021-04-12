using Banco_Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(123456, "Cersei", 100);
            conta.Depositar ( 1000);
            Console.WriteLine("Saldo: "+ conta.Saldo);

            Console.ReadKey();

        }
    }
}
