using System;
using System.Globalization;
namespace S4A42_Estoque
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        // Construtores ----------------
        public Product()
        {            
        }               

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Funções ---------------
        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;
        }

        public void AdicionarProdutos(int quantidy)
        {
            Quantity = Quantity + quantidy;
        }

        public void RemoverProdutor(int quantidy)
        {
            Quantity = Quantity - quantidy;
        }

        // Override pra informar o estoque ---------------
        public override string ToString()
        {
            return Name
                + ", $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
