using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMedica
{
    public class Paciente
    {  //atributos
        public string NomeCompleto;
        public double Altura;
        public double Peso;
        public int Idade;

        //métodos
        public double CalcularIMC()
        {
            //variável local do método
            double imc;
            imc = Peso / Math.Pow(Altura, 2);
            return imc;
        }

        public string SituacaoDoPaciente()
        {
            string mensagem = "Situação do Paciente " + NomeCompleto + ": ";
            double imc = CalcularIMC();
            if( imc < 18.5)
            {
                mensagem += "Magreza";
            } else if(imc <= 24.9)
            {
                mensagem += "Saudável";
            } else  if(imc <= 29.9)
            {
                mensagem += "Sobrepeso";
            } else if(imc <= 34.9)
            {
                mensagem += "Obesidade grau I";
            } else if(imc <= 39.9)
            {
                mensagem += "Obesidade grau II";
            }
            else
            {
                mensagem += "Obesidade grau III";
            }
            return mensagem;
        }
    }
}
