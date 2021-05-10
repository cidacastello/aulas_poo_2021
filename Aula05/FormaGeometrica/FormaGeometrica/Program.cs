using System;

namespace FormaGeometrica
{
    public abstract class FormaGeometrica
    {
        public abstract double GetArea();
        public abstract string GetNome();
    }

    public class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }
        public Quadrado() { }        
        public override double GetArea()
        {
            return Lado * Lado;
        }
        public override string GetNome()
        {
            return "Quadrado";
        }
    }
    public class Triangulo : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Triangulo() {  }
        
        public override double GetArea()
        {
            return (Base * Altura) / 2;
        }

        public override string GetNome()
        {
            return "Triangulo";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.Lado = 2;
            Console.WriteLine(quadrado.GetNome() +
                " - Área: " + quadrado.GetArea());

            Triangulo triangulo = new Triangulo();
            triangulo.Base = 2;
            triangulo.Altura = 3;
            Console.WriteLine("{0} - Área: {1}",
                triangulo.GetNome(), triangulo.GetArea());

            Console.ReadKey();
        }
    }
}
