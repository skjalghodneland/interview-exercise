using Api.Access;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController(DatabaseContext dbContext) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<ActionResult> GetTimelineById(string id)
    {
        var validGuid = Guid.TryParse(id, out var guid);
        if (!validGuid)
        {
            return BadRequest("Invalid GUID format.");
        }
        
        var timeline = await dbContext.Timelines.FirstOrDefaultAsync(t => t.Id == guid);
        if (timeline == null)
        {
            return NotFound();
        }
        
        return Ok(timeline);
    }
}