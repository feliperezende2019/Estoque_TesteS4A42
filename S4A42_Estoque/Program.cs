using System;
using System.Globalization;
namespace S4A42_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            Inventory product = new Inventory();

            // -----------------
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            product.Name = Console.ReadLine();
            Console.Write("Preço: ");
            product.Price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            product.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + product);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidy = int.Parse(Console.ReadLine());
            product.AdicionarProdutos(quantidy);
            Console.WriteLine();

            Console.WriteLine("Produtos atualizados: " + product);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidy = int.Parse(Console.ReadLine());
            product.RemoverProdutor(quantidy);
            Console.WriteLine();

            Console.WriteLine("Produtos atualizados: " + product);
        }
    }
}
