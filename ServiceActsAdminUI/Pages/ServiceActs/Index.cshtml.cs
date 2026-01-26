using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ServiceActsAdminUI.Pages.ServiceActs
{
    public class IndexModel : PageModel
    {
        public List<ServiceActDto> ServiceActs { get; set; } = new();

        public async Task OnGetAsync()
        {
            using var client = new HttpClient();
            ServiceActs = await client.GetFromJsonAsync<List<ServiceActDto>>("https://localhost:5001/api/ServiceActs");
        }
    }

    public class ServiceActDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}