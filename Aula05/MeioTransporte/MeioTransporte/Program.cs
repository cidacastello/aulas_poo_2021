using System;

namespace MeioTransporte
{
    public interface IVoador
    {
        void Voar();
    }
    public interface INavegador
    {
        void Navegar();
    }
    public class Aviao : IVoador
    {
        public void Voar()
        {
            Console.WriteLine("Avião voa");
        }
    }
    public class Hidroaviao : IVoador, INavegador
    {
        public void Navegar()
        {
            Console.WriteLine("O hidroavião navega");
        }

        public void Voar()
        {
            Console.WriteLine("O hidroavião voa");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IVoador aviao = new Aviao();
            aviao.Voar();

            Hidroaviao hidroaviao = new Hidroaviao();
            hidroaviao.Voar();
            hidroaviao.Navegar();

            Console.ReadKey();
        }
    }
}
