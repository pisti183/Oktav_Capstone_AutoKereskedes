namespace Domain.Entities
{
    public class KerAutoKartya
    {
        public long Id { get; set; }
        public long KerAutoTeljesId { get; set; }
        public required KerAutoTeljes KerAutoTeljes { get; set; }
        public string Marka { get { return KerAutoTeljes.Marka; } }
        public string Modell { get { return KerAutoTeljes.Modell; } }
        public string GyartasiEv { get { return KerAutoTeljes.GyartasiEv; } }
        public int Ar { get { return KerAutoTeljes.Ar; } }
        public int KilometerOraAllas { get { return KerAutoTeljes.KilometerOraAllas; } }
    }
}
