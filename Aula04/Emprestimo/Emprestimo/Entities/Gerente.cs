using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo.Entities
{
    public class Gerente : Funcionario
    {
        private string departamento;
        public Gerente(string nome, double salario, string departamento) 
            : base(nome, salario)
        {
            this.departamento = departamento;
        }
    }
}
