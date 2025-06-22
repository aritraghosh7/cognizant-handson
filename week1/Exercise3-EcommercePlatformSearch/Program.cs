using System;
using Exercise3_EcommercePlatformSearch.Models;

namespace Exercise3_EcommercePlatformSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(205, "T-Shirt", "Apparel"),
                new Product(308, "Smartphone", "Electronics"),
                new Product(410, "Book", "Education"),
                new Product(512, "Shoes", "Footwear")
            };

            Console.WriteLine(" Linear Search for 'Book':");
            var linearResult = LinearSearch(products, "Book");
            Console.WriteLine(linearResult != null ? $"Found: {linearResult.ProductName}" : "Not Found");

            Console.WriteLine("\n Binary Search for 'Smartphone':");
            Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName)); // sort for binary search
            var binaryResult = BinarySearch(products, "Smartphone");
            Console.WriteLine(binaryResult != null ? $"Found: {binaryResult.ProductName}" : "Not Found");

            Console.WriteLine("\nTime Complexity Analysis:");
            Console.WriteLine("Linear Search: O(n)");
            Console.WriteLine("Binary Search: O(log n) [requires sorted array]");
            Console.WriteLine("For large datasets, Binary Search is faster and preferable.");
        }

        static Product? LinearSearch(Product[] products, string name)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        static Product? BinarySearch(Product[] products, string name)
        {
            int left = 0, right = products.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return products[mid];
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return null;
        }
    }
}
