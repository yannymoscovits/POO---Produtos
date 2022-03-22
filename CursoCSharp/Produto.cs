using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;
        public int add;
        public int remov;

        public double ValorTotalEmEstoque()
        {
         return preco * quantidade;
        }

        public void AdicionarProdutos()
        {
            
            quantidade = quantidade + add;
        }

        public void RemoverProdutos()
        {
            quantidade = quantidade - remov;
        }
    }
}
