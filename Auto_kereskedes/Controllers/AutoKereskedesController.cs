using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Auto_kereskedes.Controllers
{
    [ApiController]
    [Route("api/autoKereskedes")]
    public class AutoKereskedesController(IAutoKereskedesService autoKereskedesService) : ControllerBase
    {
        [HttpGet("filters")]
        public async Task<IActionResult> Filter([FromQuery] string[] filter)
        {
            IEnumerable<Auto> result = await autoKereskedesService.GetAutoByFiltersAsync(filter);

            return result switch
            {
                _ when result.Count() == 0 => NotFound(),
                _ => Ok(result)
            };
        }
    }
}
