namespace Domain.Entities
{
    public class BerFoglalas
    {
        private BerFoglalas() { }

        public long Id { get; set; }
        public long BerAutoId { get; set; }
        public required BerAuto BerAuto { get; set; }
        public required string TeljesNev { get; set; }
        public required string TelefonSzam { get; set; }
        public string Marka { get; private set; } = string.Empty;
        public string Modell { get; private set; } = string.Empty;
        public int BerlesNapiAra { get; private set; }
        public required DateOnly AtvetelDatuma { get; set; }
        public required DateOnly VisszaadasDatuma { get; set; }
        public required string AtvetelHelyszine { get; set; }

        public BerFoglalas(BerAuto berAuto, string teljesNev, string telefonSzam, DateOnly atvetelDatuma, DateOnly visszaadasDatuma, string atvetelHelyszine)
        {
            BerAuto = berAuto;
            BerAutoId = berAuto.Id;
            TeljesNev = teljesNev;
            TelefonSzam = telefonSzam;
            Marka = berAuto.Marka;
            Modell = berAuto.Modell;
            BerlesNapiAra = berAuto.BerlesNapiAra;
            AtvetelDatuma = atvetelDatuma;
            VisszaadasDatuma = visszaadasDatuma;
            AtvetelHelyszine = atvetelHelyszine;
        }
    }
}
