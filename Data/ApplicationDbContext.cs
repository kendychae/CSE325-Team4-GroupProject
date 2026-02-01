using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServeHub.Models;

namespace ServeHub.Data;

/// <summary>
/// Database context for ServeHub application
/// Handles all database operations and entity configurations
/// </summary>
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ServiceOpportunity> ServiceOpportunities { get; set; }
    public DbSet<ServiceRegistration> ServiceRegistrations { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Configure ServiceOpportunity
        builder.Entity<ServiceOpportunity>(entity =>
        {
            entity.HasKey(e => e.Id);
            
            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(200);
            
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(2000);
            
            entity.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(300);
            
            entity.HasOne(e => e.CreatedBy)
                .WithMany(u => u.CreatedOpportunities)
                .HasForeignKey(e => e.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasIndex(e => e.StartDate);
            entity.HasIndex(e => e.Category);
            entity.HasIndex(e => e.IsActive);
        });

        // Configure ServiceRegistration
        builder.Entity<ServiceRegistration>(entity =>
        {
            entity.HasKey(e => e.Id);
            
            entity.HasOne(e => e.User)
                .WithMany(u => u.Registrations)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            
            entity.HasOne(e => e.Opportunity)
                .WithMany(o => o.Registrations)
                .HasForeignKey(e => e.OpportunityId)
                .OnDelete(DeleteBehavior.Cascade);
            
            // Ensure a user can only register once per opportunity
            entity.HasIndex(e => new { e.UserId, e.OpportunityId })
                .IsUnique();
        });
    }
}
