using System;
using Emprestimo.Entities;
namespace Emprestimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Daenerys Targaryen", 3500);
            Console.WriteLine(c1.ToString() +
                "\n Emprestimo: " + Banco.valorEmprestimo(c1));

            Console.ReadKey();
        }
    }
}
/*
 Funcionario f1 = new Funcionario("James", 3000);
            Console.WriteLine(f1.ToString() +
                "\n Empréstimo: + " + Banco.valorEmprestimo(f1));

 Pessoa f2 = new Funcionario("Arya", 4000);
            Console.WriteLine(f2.ToString() +
                "\n Emprestimo: " + Banco.valorEmprestimo(f2));

 Gerente g1 = new Gerente("Ned Stark", 5000, "Contabilidade");
            Console.WriteLine(g1.ToString() +
                "\n Emprestimo: " + Banco.valorEmprestimo(g1));
 */
