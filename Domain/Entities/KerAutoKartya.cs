namespace Domain.Entities
{
    public class KerAutoKartya
    {
        private KerAutoKartya() { }

        public long Id { get; set; }
        public long KerAutoTeljesId { get; set; }
        public required KerAutoTeljes KerAutoTeljes { get; set; }
        public string Marka { get; private set; } = string.Empty;
        public string Modell { get; private set; } = string.Empty;
        public string GyartasiEv { get; private set; } = string.Empty;
        public int Ar { get; private set; }
        public int KilometerOraAllas { get; private set; }

        public KerAutoKartya(KerAutoTeljes kerAutoTeljes)
        {
            KerAutoTeljes = kerAutoTeljes;
            KerAutoTeljesId = kerAutoTeljes.Id;
            Marka = kerAutoTeljes.Marka;
            Modell = kerAutoTeljes.Modell;
            GyartasiEv = kerAutoTeljes.GyartasiEv;
            Ar = kerAutoTeljes.Ar;
            KilometerOraAllas = kerAutoTeljes.KilometerOraAllas;
        }
    }
}
