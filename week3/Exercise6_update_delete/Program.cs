using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailStore.Data;
using RetailStore.Models;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // ✅ Update: Change price of "Laptop"
        var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
        if (product != null)
        {
            product.Price = 70000;
            await context.SaveChangesAsync();
            Console.WriteLine($"💡 Updated '{product.Name}' price to ₹{product.Price}");
        }
        else
        {
            Console.WriteLine("⚠️ Product 'Laptop' not found for update.");
        }

        // ❌ Delete: Remove "Rice Bag"
        var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
        if (toDelete != null)
        {
            context.Products.Remove(toDelete);
            await context.SaveChangesAsync();
            Console.WriteLine($"🗑️ Deleted product: {toDelete.Name}");
        }
        else
        {
            Console.WriteLine("⚠️ Product 'Rice Bag' not found for deletion.");
        }

        // ✅ Optional: Display all products after update/delete
        Console.WriteLine("\n📦 Updated Product List:");
        var products = await context.Products.ToListAsync();
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
    }
}
