namespace Domain.Entities
{
    public class BerAuto
    {
        private int berlesNapiAra;

        public long Id { get; set; }
        public required string Marka { get; set; }
        public required string Modell { get; set; }
        public required string Kivitel { get; set; }
        public required string Uzemanyag { get; set; }
        public required string ValtoTipus { get; set; }
        public required int BerlesNapiAra
        { 
            get { return berlesNapiAra; }
            set
            {
                if (value < 0) { berlesNapiAra = 0; }
                else { berlesNapiAra = value; }
            }
        }
        public ICollection<BerFoglalas> BerFoglalasok { get; set; } = [];
    }
}
