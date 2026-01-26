using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ServiceActsAdminUI.Pages.ServiceActs
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ServiceActDto ServiceAct { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            using var client = new HttpClient();
            var response = await client.PostAsJsonAsync("https://localhost:5001/api/ServiceActs", ServiceAct);
            if (!response.IsSuccessStatusCode)
                return Page();
            return RedirectToPage("Index");
        }
    }
}