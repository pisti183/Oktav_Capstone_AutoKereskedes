using Domain.Entities;

namespace Application.Repositries
{
    public interface IAutoKereskedesRepository
    {
        public Task<IEnumerable<KerAutoTeljes>> GetAllKerAutoTeljesAsync(CancellationToken cancellationToken);
        public Task<IEnumerable<KerAutoKartya>> GetKerAutoKartyaByFiltersAsync(string[] filter, CancellationToken cancellationToken);
    }
}
