namespace Domain.Entities
{
    public class Auto
    {
        //Ahol kell alkalmazni adatmezőt, hogy kontrollálni lehessen a bevitelt

        public long Id { get; set; }
        public required string Rendszam { get; set; }
        public required string Marka { get; set; }
        public required string Modell { get; set; }
        public required string GyartasiEvHonap { get; set; }
        public required int Ar { get; set; }
        public required string MotorTipus { get; set; }
        public required int TeljesitmenyKw { get; set; }
        public required int TeljesitmenyLe { get; set; }
        public required int  KilometerOraAllas { get; set; }
        public required string Uzemanyag { get; set; }
        public required string ValtoTipus { get; set; }
        public required DateOnly MuszakiVizsga { get; set; }
        public required string Szin { get; set; }
        public required int Hengerurtartalom { get; set; }
        public required int AjtokSzama { get; set; }
        public required int SzallithatoSzemelyekSzama { get; set; }
        public required string OkmanyokJellege { get; set; }
        public required string Leiras { get; set; }
        public required AutoFelszereltseg Felszereltseg { get; set; }

    }
}
