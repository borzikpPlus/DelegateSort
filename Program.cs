using System.Text;

namespace DelegateSort;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Product[] products =
        {
            new Product("Молоко", 42.50m, 30),
            new Product("Хліб", 28.00m, 50),
            new Product("Сир", 189.90m, 12),
            new Product("Яблука", 54.30m, 80),
            new Product("Кава", 349.00m, 7),
            new Product("Банани", 69.90m, 25),
        };

        Print("Початковий масив", products);

        Comparer byTitle = new Comparer(Product.CompareByTitle);
        Sorter.Sort(products, byTitle);
        Print("Сортування за назвою", products);

        Comparer byPrice = new Comparer(Product.CompareByPrice);
        Sorter.Sort(products, byPrice);
        Print("Сортування за ціною", products);

        Comparer byCount = new Comparer(Product.CompareByCount);
        Sorter.Sort(products, byCount);
        Print("Сортування за кількістю", products);
    }

    static void Print(string header, Product[] products)
    {
        Console.WriteLine($"--- {header} ---");
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine();
    }
}
