using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas_Interface
{
    public interface IFormaGeometrica
    {
        double getArea();
        string getNome();
    }
    public abstract class FormaGemetrica : IFormaGeometrica
    {
        public string Cor { get; set; }
        public abstract double getArea();
        public abstract string getNome();       
    }

    public class Quadrado : FormaGemetrica
    {
        public Quadrado()
        {
        }
        public double Lado { get; set; }

        public override double getArea()
        {
            return Lado * Lado;
        }

        public override string getNome()
        {
            return "Quadrado";
        }
    }
    public class Triangulo : FormaGemetrica
    {
        public Triangulo()
        {
        }

        public double Base { get; set; }
        public double Altura { get; set; }

        public override double getArea()
        {
            return (Base * Altura) / 2;
        }

        public override string getNome()
        {
            return "Triângulo";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.Lado = 2;
            quadrado.Cor = "Azul";
            Console.WriteLine("{0}, {1} - Área = {2}", quadrado.getNome(), 
                quadrado.Cor, quadrado.getArea() );

            Triangulo triangulo = new Triangulo();
            triangulo.Base = 2;
            triangulo.Altura = 3;
            triangulo.Cor = "Amarelo";
            Console.WriteLine("{0}, {1} - Área = {2}", triangulo.getNome(), 
                triangulo.Cor, triangulo.getArea());

            Console.ReadKey();

        }
    }
}
