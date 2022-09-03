using System;
using System.Globalization;

namespace Produto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            
                      
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine(); 
            
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), 
                CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine(),
               CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o número de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);


            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
