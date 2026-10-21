namespace Domain.Entities
{
    public class BerFoglalas
    {
        public long Id { get; set; }
        public long BerAutoId { get; set; }
        public required BerAuto BerAuto { get; set; }
        public required string TeljesNev { get; set; }
        public required string TelefonSzam { get; set; }
        public string Marka { get { return BerAuto.Marka; } }
        public string Modell { get { return BerAuto.Modell; } }
        public int BerlesNapiAra { get { return BerAuto.BerlesNapiAra; } }
        public required DateOnly AtvetelDatuma { get; set; }
        public required DateOnly VisszaadasDatuma { get; set; }
        public required string AtvetelHelyszine { get; set; }
    }
}
