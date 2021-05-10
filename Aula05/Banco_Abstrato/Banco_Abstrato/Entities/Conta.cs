using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Abstrato.Entities
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor); 
    }
}
