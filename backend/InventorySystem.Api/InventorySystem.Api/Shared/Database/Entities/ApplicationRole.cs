﻿using Microsoft.AspNetCore.Identity;

namespace InventorySystem.Api.Shared.Database.Entities;

public class ApplicationRole : IdentityRole<Guid>
{
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}