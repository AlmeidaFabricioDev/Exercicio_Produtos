using System.Globalization;

namespace Exercicio_Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produto que será regristrado : ");
            int num = int.Parse(Console.ReadLine());

            Products[] prod = new Products[num];
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                Console.Write("Informe o nome do produto " + (i + 1) + "º : ");
                string name = Console.ReadLine();
                Console.Write("Informe o preco : ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Informe a quantidade : ");
                int qty = int.Parse(Console.ReadLine());
                prod[i] = new Products(name, price, qty);
            }

            //Abaixo ordenando os produtos por preço.
            for (int i = (prod.Length - 1); i >= 0; i--)
            {
                for (int j = 0; j < (prod.Length - 1); j++)
                {
                    if (prod[j].ProductPrice > prod[j + 1].ProductPrice)
                    {
                        double localTroca = prod[j].ProductPrice;
                        prod[j].ProductPrice = prod[j + 1].ProductPrice;
                        prod[j + 1].ProductPrice = localTroca;

                        string stringTroca = prod[j].ProductName;
                        prod[j].ProductName = prod[j + 1].ProductName;
                        prod[j + 1].ProductName = stringTroca;

                        int intTroca = prod[j].ProductQuantity;
                        prod[j].ProductQuantity = prod[j + 1].ProductQuantity;
                        prod[j + 1].ProductQuantity = intTroca;

                    }
                }
            }
            Console.WriteLine("------------------------------------------");

            //Ordenação Preço dos produtos por ordem Decrescente (Maior para menor)
            Console.WriteLine("Maiores preços");
            for (int i = (prod.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(prod[i].ProductName + " " + prod[i].ProductPrice.ToString("f2", CultureInfo.InvariantCulture));
            }


            //Ordenação Preço dos produtos por odem Crescente (Menor para maior)

            Console.WriteLine("Menores preços");
            for (int i = 0; i < (prod.Length); i++)
            {
                Console.WriteLine(prod[i].ProductName + " " + prod[i].ProductPrice.ToString("f2", CultureInfo.InvariantCulture));
            }




            // Abaixo Ordenando produtos pela quantidade
            for (int j = 0; j < (prod.Length - 1); j++)
            {
                if (prod[j].ProductQuantity > prod[j + 1].ProductQuantity)
                {
                    int localTroca = prod[j].ProductQuantity;
                    prod[j].ProductQuantity = prod[j + 1].ProductQuantity;
                    prod[j + 1].ProductQuantity = localTroca;
                }
            }

            Console.WriteLine("------------------------------------------");

            //Ordenação Quantidade dos produtos por ordem Decrescente (Maior para menor)
            Console.WriteLine("Maiores Quantidade");

            for (int i = (prod.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(prod[i].ProductName + " " + prod[i].ProductPrice.ToString("f2", CultureInfo.InvariantCulture) + " [" + prod[i].ProductQuantity + "]");
            }
            //Ordenação Quantidade dos produtos por ordem Crescente (Menor para maior)
            Console.WriteLine();
            Console.WriteLine("Menores Quantidades");
            for (int i = 0; i < (prod.Length); i++)
            {
                Console.WriteLine(prod[i].ProductName + " " + prod[i].ProductPrice.ToString("f2", CultureInfo.InvariantCulture) + " [" + prod[i].ProductQuantity + "]");
            }

        }
    }
}