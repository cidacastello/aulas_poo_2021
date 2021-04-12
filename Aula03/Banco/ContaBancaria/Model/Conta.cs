using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Model
{
    public class Conta
    {

        public string Nome { get; set; }
        public double Saldo { get; private set; }

        //encapsulamento com Properties
        private string _titular;
        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        private int _numero;
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        private double _saldo2;
        public double Saldo2
        {
            get { return _saldo2; }
        }

        //construtores sobrecarregados
        //public Conta(string titular, int numero, double saldo)
        //{
        //    _titular = titular;
        //    this.numero = numero;
        //    this.saldo = saldo;
        //}
        //public Conta(string titular, int numero)
        //{
        //    _titular = titular;
        //    this.numero = numero;            
        //}
        //construtor padrão
        public Conta() { }
        
        //getters and setters
        //public double getSaldo()
        //{
        //    return _saldo;
        //}
        //public void setSaldo(double saldo)
        //{
        //    this.saldo = saldo;
        //}
        //métodos
       public void depositar(double valor)
        {
            _saldo += valor;
        }
        
        public void sacar(double valor)
        {
            _saldo -= valor;
        }
    }
}
