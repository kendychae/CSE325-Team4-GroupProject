using Microsoft.AspNetCore.Identity;
using ServeHub.Models;

namespace ServeHub.Data;

/// <summary>
/// Extended Identity User for ServeHub application
/// </summary>
public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? ProfileImageUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastLoginAt { get; set; }
    
    // Navigation properties
    public virtual ICollection<ServiceOpportunity> CreatedOpportunities { get; set; } = new List<ServiceOpportunity>();
    public virtual ICollection<ServiceRegistration> Registrations { get; set; } = new List<ServiceRegistration>();
}
