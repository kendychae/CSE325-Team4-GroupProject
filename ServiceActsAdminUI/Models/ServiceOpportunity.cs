namespace ServiceActsAdminUI.Models;

public class ServiceOpportunity
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Location { get; set; } = "";
    public DateTime Date { get; set; }
    public string Category { get; set; } = "";
}
