namespace InventorySystem.Api.Shared.Database.Entities;

public class Inventory
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public string LocationType { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public int Reserved { get; set; }
    public int Available => Quantity - Reserved;
    public int MinLevel { get; set; } = 5;
    public int ReorderLevel { get; set; } = 10;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Product Product { get; set; } = null!;
}