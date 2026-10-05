using Domain.Entities;

namespace Application.Services
{
    public interface IAutoKereskedesService
    {
        public Task<IEnumerable<Auto>> GetAutoByFiltersAsync(string[] filter);
    }
}
