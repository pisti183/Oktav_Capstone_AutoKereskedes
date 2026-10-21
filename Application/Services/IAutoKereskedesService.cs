using Domain.Entities;

namespace Application.Services
{
    public interface IAutoKereskedesService
    {
        public Task<IEnumerable<KerAutoKartya>> GetAllAutosAsync(CancellationToken cancellationToken);
        public Task<IEnumerable<KerAutoTeljes>> GetAutoByFiltersAsync(string[] filter, CancellationToken cancellationToken);
    }
}
