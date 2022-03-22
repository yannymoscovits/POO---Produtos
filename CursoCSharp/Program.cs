using System;
using System.Globalization;
namespace CursoCSharp
{

    class Program
    {
        static void Main(string[] args)
        {

            Produto p1 = new Produto();

            Console.WriteLine("Insira o nome do produto: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Insira o preço do produto: ");
            p1.preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade do produto: ");
            p1.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto : " + p1) ;

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            p1.add = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos();
            Console.WriteLine("Dados do produto : " + p1);
            p1.remov = int.Parse(Console.ReadLine());
            p1.RemoverProdutos();
            Console.WriteLine("Dados do produto : " + p1);



        }

    }
}

