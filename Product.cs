namespace DelegateSort;

public class Product
{
    public string Title { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }

    public Product(string title, decimal price, int count)
    {
        Title = title;
        Price = price;
        Count = count;
    }

    public static bool CompareByTitle(object elem1, object elem2)
    {
        return string.Compare(((Product)elem1).Title, ((Product)elem2).Title, StringComparison.CurrentCulture) > 0;
    }

    public static bool CompareByPrice(object elem1, object elem2)
    {
        return ((Product)elem1).Price > ((Product)elem2).Price;
    }

    public static bool CompareByCount(object elem1, object elem2)
    {
        return ((Product)elem1).Count > ((Product)elem2).Count;
    }

    public override string ToString()
    {
        return $"{Title,-10} {Price,8:F2} грн {Count,5} шт.";
    }
}
