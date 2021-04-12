using Exemplo_Parametros_Nomeados_Opcionais.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Parametros_Nomeados_Opcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(preco:Convert.ToDecimal(1500), nome: "Monitor",descricao: "LG");
        }
    }
}
