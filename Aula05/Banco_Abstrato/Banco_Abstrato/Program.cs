using System;
using Banco_Abstrato.Entities;

namespace Banco_Abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca poupanca = new ContaPoupanca();
            poupanca.Depositar(1000);
            poupanca.TaxaJuros = 1;
            poupanca.AtualizarSaldo();
            Console.WriteLine("Saldo poupança: " + poupanca.Saldo);

            ContaEmpresarial empresarial = new ContaEmpresarial();
            empresarial.Depositar(15000);
            empresarial.LimiteEmprestimo = 500;
            empresarial.Emprestimo(200);
            Console.WriteLine("Saldo empresa: " + empresarial.Saldo);

            Console.ReadKey();
        }
    }
}
