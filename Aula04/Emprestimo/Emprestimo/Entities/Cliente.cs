using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo.Entities
{
    public class Cliente : Pessoa
    {
        public double limiteCredito;
        public Cliente(string nome, double limiteCredito) 
            : base(nome)
        {
            this.limiteCredito = limiteCredito;

        }
    }
}
