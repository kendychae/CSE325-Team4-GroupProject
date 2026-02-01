using System.ComponentModel.DataAnnotations;
using ServeHub.Data;

namespace ServeHub.Models;

/// <summary>
/// Represents a user's registration for a service opportunity
/// </summary>
public class ServiceRegistration
{
    public int Id { get; set; }
    
    // Foreign Keys
    [Required]
    public string UserId { get; set; } = string.Empty;
    
    [Required]
    public int OpportunityId { get; set; }
    
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
    
    public bool IsConfirmed { get; set; } = false;
    
    public bool HasAttended { get; set; } = false;
    
    [StringLength(500)]
    public string? Notes { get; set; }
    
    // Navigation properties
    public virtual ApplicationUser? User { get; set; }
    public virtual ServiceOpportunity? Opportunity { get; set; }
}
