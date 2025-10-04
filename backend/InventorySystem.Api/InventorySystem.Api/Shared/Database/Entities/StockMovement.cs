namespace InventorySystem.Api.Shared.Database.Entities;

public class StockMovement
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public string MovementType { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string? FromLocation { get; set; }
    public string? ToLocation { get; set; }
    public string? ReferenceType { get; set; }
    public Guid? ReferenceId { get; set; }
    public string? Notes { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Product Product { get; set; } = null!;
    public ApplicationUser CreatedByUser { get; set; } = null!;
}