using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Parametros_Nomeados_Opcionais.Model
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Fornecedor { get; set; }

        public Produto(string nome="sem nome", string descricao="sem descrição", 
                       decimal preco=0.0m, int quantidade=0, 
                       string fornecedor="sem fornecedor")
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
            Fornecedor = fornecedor;
        }
    }
}
