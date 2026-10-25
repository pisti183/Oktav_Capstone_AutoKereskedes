using Application.Repositries;
using Application.Services;
using Domain.Entities;

namespace Infrastructure.Servicies
{
    public class AutoKereskedesService(IAutoKereskedesRepository autoKereskedesRepository) : IAutoKereskedesService
    {
        public async Task<IEnumerable<KartyaRequest>> GetAllAutosAsync(CancellationToken cancellationToken)
        {
            IEnumerable<KerAutoTeljes> autos = await autoKereskedesRepository.GetAllKerAutoTeljesAsync(cancellationToken);

            IEnumerable<KartyaRequest> kartyaRequst = autos.Select(auto => new KartyaRequest
            {
                Marka = auto.Marka,
                Tipus = auto.Modell,
                Ar = auto.Ar,
                KilometeroraAllas = auto.KilometerOraAllas,
                Evjarat = auto.GyartasiEv
            }).ToList();

            return kartyaRequst;
        }

        public async Task<IEnumerable<KerAutoTeljes>> GetAutoByFiltersAsync(string[] filter, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
