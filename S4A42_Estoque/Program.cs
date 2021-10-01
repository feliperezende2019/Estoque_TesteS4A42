using System;
using System.Globalization;
namespace S4A42_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            Product p;
            string Name;
            double Price;
            int Quantity;

            // -----------------
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            Name = Console.ReadLine();
            Console.Write("Preço: ");
            Price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            p = new Product(Name, Price, Quantity);

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidy = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidy);
            Console.WriteLine();

            Console.WriteLine("Produtos atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidy = int.Parse(Console.ReadLine());
            p.RemoverProdutor(quantidy);
            Console.WriteLine();

            Console.WriteLine("Produtos atualizados: " + p);
        }
    }
}
