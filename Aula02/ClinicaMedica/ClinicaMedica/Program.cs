using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    class Program
    {
        static void Main(string[] args)
        {
            //paciente 1
            Paciente p1 = new Paciente();
            p1.NomeCompleto = "José Marins";
            p1.Peso = 120;
            p1.Altura = 1.75;
            p1.Idade = 38;

            double imc = p1.CalcularIMC();
            Console.WriteLine("IMC = " + imc);
            Console.WriteLine(p1.SituacaoDoPaciente());

            //paciente 2
            Paciente p2 = new Paciente();
            p2.NomeCompleto = "Andressa Costa";
            p2.Peso = 46.650;
            p2.Altura = 1.62;
            p2.Idade = 21;

           // imc = p2.CalcularIMC();
            Console.WriteLine("IMC = " + p2.CalcularIMC());
            Console.WriteLine(p2.SituacaoDoPaciente());

            Console.ReadKey();
        }
    }

}
