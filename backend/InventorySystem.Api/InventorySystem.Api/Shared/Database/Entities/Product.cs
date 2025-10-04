using InventorySystem.Api.Shared.Interfaces;

namespace InventorySystem.Api.Shared.Database.Entities;

public class Product : IAuditableEntity
{
    public Guid Id { get; set; }
    public string Sku { get; set; } = string.Empty;
    public string? Ean { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? BrandId { get; set; }
    public decimal Price { get; set; }
    public decimal? Cost { get; set; }
    public decimal TaxRate { get; set; } = 0.23m;
    public string Status { get; set; } = "active";
    public string? ImageUrl { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string? UpdatedBy { get; set; }
    
    public Category? Category { get; set; }
    public Brand? Brand { get; set; }
    public ICollection<Inventory> InventoryRecords { get; set; } = new List<Inventory>();
    public ICollection<SaleItem> SaleItems { get; set; } = new List<SaleItem>();
}