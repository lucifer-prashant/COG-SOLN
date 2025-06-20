using System;

class Program
{
    static Product LinearSearch(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }

    static Product BinarySearch(Product[] products, string name)
    {
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int comparison = string.Compare(products[mid].ProductName, name, true);
            if (comparison == 0)
                return products[mid];
            else if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }

    static void Main()
    {
        var products = new Product[]
        {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Fashion"),
            new Product(3, "Phone", "Electronics"),
            new Product(4, "Watch", "Accessories"),
            new Product(5, "Bag", "Fashion")
        };

        Console.WriteLine("Enter product name to search:");
        string searchName = Console.ReadLine();

        var result1 = LinearSearch(products, searchName);
        Console.WriteLine("\n[Linear Search]");
        Console.WriteLine(result1 != null ? result1.ToString() : "Product not found.");

        Array.Sort(products, (a, b) => string.Compare(a.ProductName, b.ProductName, true));
        var result2 = BinarySearch(products, searchName);
        Console.WriteLine("\n[Binary Search]");
        Console.WriteLine(result2 != null ? result2.ToString() : "Product not found.");
    }
}
