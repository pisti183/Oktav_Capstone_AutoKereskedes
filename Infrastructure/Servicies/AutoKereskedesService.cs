using Application.Repositries;
using Application.Services;
using Domain.Entities;

namespace Infrastructure.Servicies
{
    public class AutoKereskedesService(IAutoKereskedesRepository autoKereskedesRepository) : IAutoKereskedesService
    {
        public async Task<IEnumerable<KerAutoKartya>> GetAllAutosAsync(CancellationToken cancellationToken)
        {
            return await autoKereskedesRepository.GetAllKerAutoKartyaAsync(cancellationToken);
        }

        public async Task<IEnumerable<KerAutoTeljes>> GetAutoByFiltersAsync(string[] filter, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
