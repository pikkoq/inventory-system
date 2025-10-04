using Microsoft.AspNetCore.Identity;

namespace InventorySystem.Api.Shared.Database.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string FullName =>  $"{FirstName} {LastName}".Trim();

    public string? Pin { get; set; }

    public string? DefaultLocation { get; set; }

    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastLoginAt { get; set; }
    public string? CreatedBy { get; set; }

    public virtual ICollection<CashierSession> CashierSessions { get; set; } = new List<CashierSession>();
    public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
}