namespace ServeHub.Application.DTOs.History;

public class ServiceHistoryDto
{
    public string Title { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public DateTime CompletionDate { get; set; }
}
