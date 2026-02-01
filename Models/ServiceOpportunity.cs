using System.ComponentModel.DataAnnotations;
using ServeHub.Data;

namespace ServeHub.Models;

/// <summary>
/// Represents a volunteer service opportunity
/// </summary>
public class ServiceOpportunity
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Description is required")]
    [StringLength(2000, ErrorMessage = "Description cannot exceed 2000 characters")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "Location is required")]
    [StringLength(300, ErrorMessage = "Location cannot exceed 300 characters")]
    public string Location { get; set; } = string.Empty;

    [Required(ErrorMessage = "Start date is required")]
    [DataType(DataType.DateTime)]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "End date is required")]
    [DataType(DataType.DateTime)]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Maximum volunteers is required")]
    [Range(1, 1000, ErrorMessage = "Maximum volunteers must be between 1 and 1000")]
    public int MaxVolunteers { get; set; }

    public int CurrentVolunteers { get; set; } = 0;

    [StringLength(500)]
    public string? ImageUrl { get; set; }

    public string? Category { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Foreign Key
    public string CreatedByUserId { get; set; } = string.Empty;

    // Navigation properties
    public virtual ApplicationUser? CreatedBy { get; set; }
    public virtual ICollection<ServiceRegistration> Registrations { get; set; } = new List<ServiceRegistration>();
}
