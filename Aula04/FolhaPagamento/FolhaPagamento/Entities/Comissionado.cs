using System;
using System.Collections.Generic;
using System.Text;

namespace FolhaPagamento.Entities
{
    public class Comissionado : Empregado
    {
        private double comissao;
        public Comissionado()
        {
        }

        public Comissionado(string nome, double salarioBase, double comissao) 
            : base(nome, salarioBase)
        {
            this.comissao = comissao;
        }

        public override double CalcularPagamento()
        {
            return base.CalcularPagamento() + comissao;
        }
    }
}
