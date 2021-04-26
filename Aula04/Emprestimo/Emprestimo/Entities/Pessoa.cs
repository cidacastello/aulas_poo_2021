using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo.Entities
{
    public class Pessoa
    {
        private string nome;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }
        public override string ToString()
        {
            return "\n Dados da Pessoa: Nome: " + nome;
        }
    }
}
