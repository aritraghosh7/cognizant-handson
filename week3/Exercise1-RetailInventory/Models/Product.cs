namespace RetailInventory.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Stock { get; set; }

    // Foreign Key
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
