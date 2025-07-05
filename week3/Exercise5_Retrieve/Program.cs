using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailStore.Data;
using RetailStore.Models;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // 1. Retrieve All Products
        var products = await context.Products.ToListAsync();
        Console.WriteLine("📦 All Products:");
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - ₹{p.Price}");

        Console.WriteLine();

        // 2. Find Product by ID
        var product = await context.Products.FindAsync(1);
        Console.WriteLine($"🔍 Found by ID 1: {product?.Name ?? "Not found"}");

        Console.WriteLine();

        // 3. FirstOrDefault with Condition
        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"💰 Expensive Product: {expensive?.Name ?? "None above ₹50,000"}");
    }
}
