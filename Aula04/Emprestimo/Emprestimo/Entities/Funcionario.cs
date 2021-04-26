using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo.Entities
{
    public class Funcionario : Pessoa
    {
        public double salario;
        public Funcionario(string nome, double salario) 
            : base(nome)
        {
            this.salario = salario;
        }

        public override string ToString()
        {
            return "\n\nFuncionario: " + base.ToString() +
                "\n Salario: " + salario;
        }
    }
}
