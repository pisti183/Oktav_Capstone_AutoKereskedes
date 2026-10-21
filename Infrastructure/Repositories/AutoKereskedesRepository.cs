using Application.Repositries;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AutoKereskedesRepository(ApplicationDbContext context) : IAutoKereskedesRepository
    {
        public async Task<IEnumerable<KerAutoKartya>> GetAllKerAutoKartyaAsync(CancellationToken cancellationToken)
        {
            return await context.KerAutoKartyak.ToListAsync(cancellationToken);
        }

        public Task<IEnumerable<KerAutoKartya>> GetKerAutoKartyaByFiltersAsync(string[] filter, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
