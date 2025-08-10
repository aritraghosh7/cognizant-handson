using RetailInventory.Data;
using RetailInventory.Models;

using var context = new InventoryContext();

// Ensure database exists and is up-to-date
Console.WriteLine("Connected to RetailInventoryDB \n");

// Fetch and display categories
var categories = context.Categories.ToList();
Console.WriteLine(" Categories:");
foreach (var category in categories)
{
    Console.WriteLine($"- [{category.CategoryId}] {category.Name}");
}

// Fetch and display products with category info
var products = context.Products.ToList();
Console.WriteLine("\n Products:");
foreach (var product in products)
{
    var categoryName = categories.FirstOrDefault(c => c.CategoryId == product.CategoryId)?.Name ?? "Unknown";
    Console.WriteLine($"- [{product.ProductId}] {product.Name} (Stock: {product.Stock}, Category: {categoryName})");
}

Console.WriteLine("\n Data displayed successfully.");
