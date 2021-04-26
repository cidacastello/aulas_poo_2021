using System;
using System.Collections.Generic;
using System.Text;

namespace FolhaPagamento.Entities
{
    public class Empregado
    {
        public string Nome { get; set; }
        private double salarioBase;
        public Empregado()
        {                
        }

        public Empregado(string nome, double salarioBase)
        {
            Nome = nome;
            this.salarioBase = salarioBase;
        }
        public virtual double CalcularPagamento()
        {
            return salarioBase;
        }
    }
}
