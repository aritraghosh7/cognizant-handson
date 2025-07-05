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

        // ✅ 1. Filter and Sort Products (Price > 1000, Descending)
        var filtered = await context.Products
            .Where(p => p.Price > 1000)
            .OrderByDescending(p => p.Price)
            .ToListAsync();

        Console.WriteLine("🔎 Filtered & Sorted Products (Price > ₹1000):");
        foreach (var p in filtered)
        {
            Console.WriteLine($"- {p.Name} : ₹{p.Price}");
        }

        Console.WriteLine("\n🧾 Product DTOs (Name & Price only):");

        // ✅ 2. Project into DTO (Anonymous Type with Name and Price)
        var productDTOs = await context.Products
            .Select(p => new { p.Name, p.Price })
            .ToListAsync();

        foreach (var dto in productDTOs)
        {
            Console.WriteLine($"- {dto.Name} : ₹{dto.Price}");
        }
    }
}
