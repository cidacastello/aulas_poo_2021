using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Heranca.Entities
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public Conta()
        {
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
