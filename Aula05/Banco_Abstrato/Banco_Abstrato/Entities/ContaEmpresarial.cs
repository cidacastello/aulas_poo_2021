using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Abstrato.Entities
{
   public class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public void Emprestimo(double valor)
        {
            if(valor <= LimiteEmprestimo)
            {
                Saldo += valor;
            }
        }
    }
}
