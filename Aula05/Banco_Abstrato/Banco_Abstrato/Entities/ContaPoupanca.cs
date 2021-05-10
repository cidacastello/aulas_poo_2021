using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Abstrato.Entities
{
    public class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }
        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public void AtualizarSaldo()
        {
            Saldo = (Saldo * TaxaJuros / 100) + Saldo;
        }
    }
}
