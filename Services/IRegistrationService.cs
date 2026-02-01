using ServeHub.Models;

namespace ServeHub.Services;

/// <summary>
/// Service interface for managing service registrations
/// </summary>
public interface IRegistrationService
{
    Task<List<ServiceRegistration>> GetUserRegistrationsAsync(string userId);
    Task<List<ServiceRegistration>> GetOpportunityRegistrationsAsync(int opportunityId);
    Task<ServiceRegistration?> GetRegistrationAsync(int id);
    Task<ServiceRegistration> RegisterForOpportunityAsync(string userId, int opportunityId, string? notes = null);
    Task<bool> CancelRegistrationAsync(int id);
    Task<bool> ConfirmAttendanceAsync(int id);
}
