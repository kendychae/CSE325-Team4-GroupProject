using Microsoft.EntityFrameworkCore;
using ServeHub.Data;
using ServeHub.Models;

namespace ServeHub.Services;

/// <summary>
/// Service implementation for managing service registrations
/// </summary>
public class RegistrationService : IRegistrationService
{
    private readonly ApplicationDbContext _context;

    public RegistrationService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<ServiceRegistration>> GetUserRegistrationsAsync(string userId)
    {
        return await _context.ServiceRegistrations
            .Include(r => r.Opportunity)
            .Where(r => r.UserId == userId)
            .OrderByDescending(r => r.RegisteredAt)
            .ToListAsync();
    }

    public async Task<List<ServiceRegistration>> GetOpportunityRegistrationsAsync(int opportunityId)
    {
        return await _context.ServiceRegistrations
            .Include(r => r.User)
            .Where(r => r.OpportunityId == opportunityId)
            .OrderBy(r => r.RegisteredAt)
            .ToListAsync();
    }

    public async Task<ServiceRegistration?> GetRegistrationAsync(int id)
    {
        return await _context.ServiceRegistrations
            .Include(r => r.User)
            .Include(r => r.Opportunity)
            .FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<ServiceRegistration> RegisterForOpportunityAsync(string userId, int opportunityId, string? notes = null)
    {
        // Check if already registered
        var existing = await _context.ServiceRegistrations
            .FirstOrDefaultAsync(r => r.UserId == userId && r.OpportunityId == opportunityId);

        if (existing != null)
            throw new InvalidOperationException("User is already registered for this opportunity");

        // Check if opportunity is full
        var opportunity = await _context.ServiceOpportunities
            .Include(o => o.Registrations)
            .FirstOrDefaultAsync(o => o.Id == opportunityId);

        if (opportunity == null)
            throw new InvalidOperationException("Opportunity not found");

        if (opportunity.CurrentVolunteers >= opportunity.MaxVolunteers)
            throw new InvalidOperationException("This opportunity is full");

        var registration = new ServiceRegistration
        {
            UserId = userId,
            OpportunityId = opportunityId,
            Notes = notes,
            RegisteredAt = DateTime.UtcNow
        };

        _context.ServiceRegistrations.Add(registration);

        // Update volunteer count
        opportunity.CurrentVolunteers++;

        await _context.SaveChangesAsync();
        return registration;
    }

    public async Task<bool> CancelRegistrationAsync(int id)
    {
        var registration = await _context.ServiceRegistrations
            .Include(r => r.Opportunity)
            .FirstOrDefaultAsync(r => r.Id == id);

        if (registration == null)
            return false;

        _context.ServiceRegistrations.Remove(registration);

        // Update volunteer count
        if (registration.Opportunity != null)
        {
            registration.Opportunity.CurrentVolunteers--;
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> ConfirmAttendanceAsync(int id)
    {
        var registration = await _context.ServiceRegistrations.FindAsync(id);
        if (registration == null)
            return false;

        registration.HasAttended = true;
        registration.IsConfirmed = true;
        await _context.SaveChangesAsync();
        return true;
    }
}
