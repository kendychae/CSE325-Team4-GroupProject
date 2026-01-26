using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ServiceActsAdminUI.Pages.ServiceActs
{
    public class EditModel : PageModel
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

        public async Task<IActionResult> OnPostAsync()
        {
            using var client = new HttpClient();
            var response = await client.PutAsJsonAsync($"https://localhost:5001/api/ServiceActs/{ServiceAct.Id}", ServiceAct);
            if (!response.IsSuccessStatusCode)
                return Page();
            return RedirectToPage("Index");
        }
    }
}