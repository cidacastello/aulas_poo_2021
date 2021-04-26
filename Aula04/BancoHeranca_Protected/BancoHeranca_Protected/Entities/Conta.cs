using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoHeranca_Protected.Entities
{
   public  class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }
        public Conta()
        {

        }
        public Conta(int numero, Cliente titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
                
        }
        public virtual void  Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
        }
    }
}
