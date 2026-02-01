using ServeHub.Models;

namespace ServeHub.Services;

/// <summary>
/// Service interface for managing service opportunities
/// </summary>
public interface IServiceOpportunityService
{
    Task<List<ServiceOpportunity>> GetAllOpportunitiesAsync();
    Task<List<ServiceOpportunity>> GetActiveOpportunitiesAsync();
    Task<ServiceOpportunity?> GetOpportunityByIdAsync(int id);
    Task<List<ServiceOpportunity>> GetOpportunitiesByCategoryAsync(string category);
    Task<ServiceOpportunity> CreateOpportunityAsync(ServiceOpportunity opportunity);
    Task<ServiceOpportunity> UpdateOpportunityAsync(ServiceOpportunity opportunity);
    Task<bool> DeleteOpportunityAsync(int id);
    Task<List<string>> GetCategoriesAsync();
}
