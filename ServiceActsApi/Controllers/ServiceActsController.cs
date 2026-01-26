using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceActsApi.Data;
using ServiceActsApi.Models;

namespace ServiceActsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceActsController : ControllerBase
    {
        private readonly ServiceActsContext _context;

        public ServiceActsController(ServiceActsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceAct>>> GetServiceActs()
        {
            return await _context.ServiceActs.ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditServiceAct(int id, ServiceAct serviceAct)
        {
            if (id != serviceAct.Id)
                return BadRequest();

            _context.Entry(serviceAct).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.ServiceActs.Any(e => e.Id == id))
                    return NotFound();
                else
                    throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceAct(int id)
        {
            var serviceAct = await _context.ServiceActs.FindAsync(id);
            if (serviceAct == null)
                return NotFound();

            _context.ServiceActs.Remove(serviceAct);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}