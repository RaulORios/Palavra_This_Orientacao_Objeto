using System;
using System.Globalization;

namespace Palavra_This_Orientacao_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto >>>");
            Console.Write("Nome: ");
            string nome = (Console.ReadLine());
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);
                        
            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

            Console.ReadKey();
        }
    }
}
