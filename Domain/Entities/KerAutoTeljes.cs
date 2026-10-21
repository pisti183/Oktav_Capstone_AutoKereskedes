namespace Domain.Entities
{
    public class KerAutoTeljes
    {
        private int ar;
        private int teljesitmenyKw;
        private int teljesitmenyLe;
        private int kilometerOraAllas;
        private int hengerurtartalom;
        private int ajtokSzama;
        private int szallithatoSzemelyekSzama;

        public long Id { get; set; }
        public long KerAutoFelszereltsegId { get; set; }
        public required KerAutoFelszereltseg KerAutoFelszereltseg { get; set; } = null!;
        public long KerAutoKartyaId { get; set; }
        public required KerAutoKartya KerAutoKartya { get; set; }
        public required string Rendszam { get; set; }
        public required string Marka { get; set; }
        public required string Modell { get; set; }
        public required string GyartasiEv { get; set; }
        public required int Ar
        { 
            get { return ar; }
            set
            { 
                if (value < 0) { ar = 0; } 
                else { ar = value; } 
            } 
        }
        public required string MotorTipus { get; set; }
        public required int TeljesitmenyKw
        { 
            get { return teljesitmenyKw; } 
            set 
            { 
                if (value < 0) { teljesitmenyKw = 0; } 
                else { teljesitmenyKw = value; } 
            }
        }
        public required int TeljesitmenyLe
        { 
            get { return teljesitmenyLe; } 
            set 
            { 
                if (value < 0) { teljesitmenyLe = 0; } 
                else { teljesitmenyLe = value; } 
            }
        }
        public required int  KilometerOraAllas
        { 
            get { return kilometerOraAllas; } 
            set 
            { 
                if (value < 0) { kilometerOraAllas = 0; } 
                else { kilometerOraAllas = value; } 
            }
        }
        public required string Uzemanyag { get; set; }
        public required string ValtoTipus { get; set; }
        public required DateOnly MuszakiVizsga { get; set; }
        public required string Szin { get; set; }
        public required int Hengerurtartalom
        { 
            get { return hengerurtartalom; } 
            set 
            { 
                if (value < 0) { hengerurtartalom = 0; } 
                else { hengerurtartalom = value; } 
            } 
        }
        public required int AjtokSzama
        { 
            get { return ajtokSzama; } 
            set 
            { 
                if (value < 0) { ajtokSzama = 0; } 
                else { ajtokSzama = value; } 
            }
        }
        public required int SzallithatoSzemelyekSzama
        { 
            get { return szallithatoSzemelyekSzama; } 
            set 
            { 
                if (value < 0) { szallithatoSzemelyekSzama = 0; } 
                else { szallithatoSzemelyekSzama = value; } 
            }
        }
        public required string OkmanyokJellege { get; set; }
        public required string Leiras { get; set; }
    }
}
