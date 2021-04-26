using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo.Entities
{
    public class Banco
    {
        public static double valorEmprestimo(Pessoa pessoa)
        {
            double valor; 
            if (pessoa is Gerente)
            {
                valor = ((Gerente)pessoa).salario * 10;
            }
            else if (pessoa is Funcionario)
            {
                valor = ((Funcionario)pessoa).salario * 5;
            }
            else if (pessoa is Cliente)
            {
                valor = ((Cliente)pessoa).limiteCredito * 2;
            }
            else
            {
                valor = 0;
            }
            return valor;
        }
    }
}
