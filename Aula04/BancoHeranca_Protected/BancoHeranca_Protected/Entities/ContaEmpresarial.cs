using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoHeranca_Protected.Entities
{
    public class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }        

        public override void Sacar(double valor)
        {
            Saldo = Saldo - valor - 5;
        }
       

    }
}
