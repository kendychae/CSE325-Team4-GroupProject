using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServeHub.Application.DTOs.History;
using ServeHub.Application.Interfaces;

namespace ServeHub.API.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly IOpportunityService _opportunityService;

    public UsersController(IOpportunityService opportunityService)
    {
        _opportunityService = opportunityService;
    }

    [HttpGet("me/history")]
    public async Task<ActionResult<List<ServiceHistoryDto>>> GetMyHistory()
    {
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userIdClaim == null)
            return Unauthorized();

        var userId = int.Parse(userIdClaim);
        var history = await _opportunityService.GetUserHistoryAsync(userId);
        
        return Ok(history);
    }
}
