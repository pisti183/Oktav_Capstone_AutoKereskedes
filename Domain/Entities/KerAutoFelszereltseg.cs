namespace Domain.Entities
{
    public class KerAutoFelszereltseg
    {
        public long Id { get; set; }
        public long KerAutoTeljesId { get; set; }
        public required KerAutoTeljes KerAutoTeljes { get; set; } = null!;
        public required bool FuthetoUles { get; set; } = false;
        public required bool FuthetoKormany { get; set; } = false;
        public required bool ElektromosUllesAllitas { get; set; } = false;
        public required bool AllithatoKormany { get; set; } = false;
        public required bool KikapcsolhatoLegzsak { get; set; } = false;
        public required bool VezetoOldaliLegzsak { get; set; } = false;
        public required bool UtasoldaliLegzsak { get; set; } = false;
        public required bool OldalLegzsak { get; set; } = false;
        public required bool KozepsoKartamasz { get; set; } = false;
        public required bool DerekTamasz { get; set; } = false;
        public required bool IsofixRendszer { get; set; } = false;
        public required bool TolatoKamera { get; set; } = false;
        public required bool TolatoRadar { get; set; } = false;
        public required bool ElsoHatsoParkoloradar { get; set; } = false;
        public required bool Asr { get; set; } = false;
        public required bool Esp { get; set; } = false;
        public required bool Abs { get; set; } = false;
        public required bool VisszagurulasGatlo { get; set; } = false;
        public required bool Szervokormany { get; set; } = false;
        public required bool HoltterFigyelo { get; set; } = false;
        public required bool Tempomat { get; set; } = false;
        public required bool InditasGatlo { get; set; } = false;
        public required bool Riaszto { get; set; } = false;
        public required bool ElektromosAblak { get; set; } = false;
        public required bool FuthetoTukor { get; set; } = false;
        public required bool ToloTeto { get; set; } = false;
        public required bool EsoSzenzor { get; set; } = false;
        public required bool KonnyufemFelni { get; set; } = false;
        public required bool Gps { get; set; } = false;
        public required bool ErintoKijelzo { get; set; } = false;
        public required bool BluetotthosKihangosito { get; set; } = false;
        public required bool UsbCsatlakozo { get; set; } = false;
        public required bool VezetekNelkuliTelefonToltes { get; set; } = false;
        public required bool AfaVisszaigenyelheto { get; set; } = false;
        public required bool Garancialis { get; set; } = false;
    }
}
