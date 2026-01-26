using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ServiceActsAdminUI.Pages.ServiceActs
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public ServiceActDto ServiceAct { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            using var client = new HttpClient();
            ServiceAct = await client.GetFromJsonAsync<ServiceActDto>($"https://localhost:5001/api/ServiceActs/{id}");
            if (ServiceAct == null)
                return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            using var client = new HttpClient();
            var response = await client.DeleteAsync($"https://localhost:5001/api/ServiceActs/{id}");
            if (!response.IsSuccessStatusCode)
                return Page();
            return RedirectToPage("Index");
        }
    }
}