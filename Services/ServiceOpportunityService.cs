using Microsoft.EntityFrameworkCore;
using ServeHub.Data;
using ServeHub.Models;

namespace ServeHub.Services;

/// <summary>
/// Service implementation for managing service opportunities
/// </summary>
public class ServiceOpportunityService : IServiceOpportunityService
{
    private readonly ApplicationDbContext _context;

    public ServiceOpportunityService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<ServiceOpportunity>> GetAllOpportunitiesAsync()
    {
        return await _context.ServiceOpportunities
            .Include(o => o.CreatedBy)
            .Include(o => o.Registrations)
            .OrderByDescending(o => o.CreatedAt)
            .ToListAsync();
    }

    public async Task<List<ServiceOpportunity>> GetActiveOpportunitiesAsync()
    {
        return await _context.ServiceOpportunities
            .Include(o => o.CreatedBy)
            .Include(o => o.Registrations)
            .Where(o => o.IsActive && o.StartDate > DateTime.UtcNow)
            .OrderBy(o => o.StartDate)
            .ToListAsync();
    }

    public async Task<ServiceOpportunity?> GetOpportunityByIdAsync(int id)
    {
        return await _context.ServiceOpportunities
            .Include(o => o.CreatedBy)
            .Include(o => o.Registrations)
            .ThenInclude(r => r.User)
            .FirstOrDefaultAsync(o => o.Id == id);
    }

    public async Task<List<ServiceOpportunity>> GetOpportunitiesByCategoryAsync(string category)
    {
        return await _context.ServiceOpportunities
            .Include(o => o.CreatedBy)
            .Include(o => o.Registrations)
            .Where(o => o.Category == category && o.IsActive)
            .OrderBy(o => o.StartDate)
            .ToListAsync();
    }

    public async Task<ServiceOpportunity> CreateOpportunityAsync(ServiceOpportunity opportunity)
    {
        opportunity.CreatedAt = DateTime.UtcNow;
        _context.ServiceOpportunities.Add(opportunity);
        await _context.SaveChangesAsync();
        return opportunity;
    }

    public async Task<ServiceOpportunity> UpdateOpportunityAsync(ServiceOpportunity opportunity)
    {
        opportunity.UpdatedAt = DateTime.UtcNow;
        _context.ServiceOpportunities.Update(opportunity);
        await _context.SaveChangesAsync();
        return opportunity;
    }

    public async Task<bool> DeleteOpportunityAsync(int id)
    {
        var opportunity = await _context.ServiceOpportunities.FindAsync(id);
        if (opportunity == null)
            return false;

        _context.ServiceOpportunities.Remove(opportunity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<string>> GetCategoriesAsync()
    {
        return await _context.ServiceOpportunities
            .Where(o => !string.IsNullOrEmpty(o.Category))
            .Select(o => o.Category!)
            .Distinct()
            .OrderBy(c => c)
            .ToListAsync();
    }
}
