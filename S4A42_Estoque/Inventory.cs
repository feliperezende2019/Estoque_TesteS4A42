using System;
using System.Globalization;
namespace S4A42_Estoque
{
    class Inventory
    {
        public string Name;
        public double Price;
        public int Quantity;

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
