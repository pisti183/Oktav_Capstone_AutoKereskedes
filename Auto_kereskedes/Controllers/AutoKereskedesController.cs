using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auto_kereskedes.Controllers
{
    [ApiController]
    [Route("api/autoKereskedes")]
    public class AutoKereskedesController(IAutoKereskedesService autoKereskedesService) : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("/")]
        public async Task<IActionResult> AllAutos(CancellationToken cancellationToken)
        {
            IEnumerable<KerAutoKartya> result = await autoKereskedesService.GetAllAutosAsync(cancellationToken);

            return result switch
            {
                _ when result.Count() == 0 => NotFound(),
                _ => Ok(result)
            };
        }

        [AllowAnonymous]
        [HttpGet("filters")]
        public async Task<IActionResult> Filter([FromQuery] string[] filter, CancellationToken cancellationToken)
        {
            IEnumerable<KerAutoTeljes> result = await autoKereskedesService.GetAutoByFiltersAsync(filter, cancellationToken);

            return result switch
            {
                _ when result.Count() == 0 => NotFound(),
                _ => Ok(result)
            };
        }
    }
}
