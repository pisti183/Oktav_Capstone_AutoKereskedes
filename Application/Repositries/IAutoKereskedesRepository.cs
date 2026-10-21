using Domain.Entities;

namespace Application.Repositries
{
    public interface IAutoKereskedesRepository
    {
        public Task<IEnumerable<KerAutoKartya>> GetAllKerAutoKartyaAsync(CancellationToken cancellationToken);
        public Task<IEnumerable<KerAutoKartya>> GetKerAutoKartyaByFiltersAsync(string[] filter, CancellationToken cancellationToken);
    }
}
