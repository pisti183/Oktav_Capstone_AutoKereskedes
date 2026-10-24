using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<KerAutoTeljes> KerAutoTeljesek { get; set; }
        public DbSet<KerAutoFelszereltseg> KerAutoFelszereltsegek { get; set; }
        public DbSet<KerAutoKartya> KerAutoKartyak { get; set; }
        public DbSet<BerAuto> BerAutok { get; set; }
        public DbSet<BerFoglalas> BerFoglalasok { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<KerAutoTeljes>(c =>
            {
                c.ToTable("KerAutoTeljes");
                c.HasKey(a => a.Id);
                c.Property(a => a.KerAutoFelszereltsegId).IsRequired(true);
                c.Property(a => a.KerAutoKartyaId).IsRequired(true);
                c.Property(a => a.Rendszam).HasMaxLength(7).IsRequired(true);
                c.Property(a => a.Marka).HasMaxLength(25).IsRequired(true);
                c.Property(a => a.Modell).HasMaxLength(25).IsRequired(true);
                c.Property(a => a.GyartasiEv).HasMaxLength(4).IsRequired(true);
                c.Property(a => a.Ar).IsRequired(true);
                c.Property(a => a.MotorTipus).HasMaxLength(50).IsRequired(true);
                c.Property(a => a.TeljesitmenyKw).IsRequired(true);
                c.Property(a => a.TeljesitmenyLe).IsRequired(true);
                c.Property(a => a.KilometerOraAllas).IsRequired(true);
                c.Property(a => a.Uzemanyag).HasMaxLength(20).IsRequired(true);
                c.Property(a => a.ValtoTipus).HasMaxLength(25).IsRequired(true);
                c.Property(a => a.MuszakiVizsga).IsRequired(true);
                c.Property(a => a.Szin).HasMaxLength(25).IsRequired(true);
                c.Property(a => a.Hengerurtartalom).IsRequired(true);
                c.Property(a => a.AjtokSzama).IsRequired(true);
                c.Property(a => a.SzallithatoSzemelyekSzama).IsRequired(true);
                c.Property(a => a.OkmanyokJellege).HasMaxLength(100).IsRequired(true);
                c.Property(a => a.Leiras).IsRequired(true);

                c.HasOne(a => a.KerAutoFelszereltseg)
                    .WithOne(b => b.KerAutoTeljes)
                    .HasForeignKey<KerAutoFelszereltseg>(b => b.KerAutoTeljesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(true);

                c.HasOne(a => a.KerAutoKartya)
                    .WithOne(b => b.KerAutoTeljes)
                    .HasForeignKey<KerAutoKartya>(b => b.KerAutoTeljesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(true);
            });

            modelBuilder.Entity<KerAutoFelszereltseg>(c =>
            {
                c.ToTable("KerAutoFelszereltseg");
                c.HasKey(a => a.Id);
                c.Property(a => a.KerAutoTeljesId).IsRequired(true);
                c.Property(a => a.FuthetoUles).IsRequired(true);
                c.Property(a => a.FuthetoKormany).IsRequired(true);
                c.Property(a => a.ElektromosUllesAllitas).IsRequired(true);
                c.Property(a => a.AllithatoKormany).IsRequired(true);
                c.Property(a => a.KikapcsolhatoLegzsak).IsRequired(true);
                c.Property(a => a.VezetoOldaliLegzsak).IsRequired(true);
                c.Property(a => a.UtasoldaliLegzsak).IsRequired(true);
                c.Property(a => a.OldalLegzsak).IsRequired(true);
                c.Property(a => a.KozepsoKartamasz).IsRequired(true);
                c.Property(a => a.DerekTamasz).IsRequired(true);
                c.Property(a => a.IsofixRendszer).IsRequired(true);
                c.Property(a => a.TolatoKamera).IsRequired(true);
                c.Property(a => a.TolatoRadar).IsRequired(true);
                c.Property(a => a.ElsoHatsoParkoloradar).IsRequired(true);
                c.Property(a => a.Asr).IsRequired(true);
                c.Property(a => a.Esp).IsRequired(true);
                c.Property(a => a.Abs).IsRequired(true);
                c.Property(a => a.VisszagurulasGatlo).IsRequired(true);
                c.Property(a => a.Szervokormany).IsRequired(true);
                c.Property(a => a.HoltterFigyelo).IsRequired(true);
                c.Property(a => a.Tempomat).IsRequired(true);
                c.Property(a => a.InditasGatlo).IsRequired(true);
                c.Property(a => a.Riaszto).IsRequired(true);
            });

            modelBuilder.Entity<KerAutoKartya>(c =>
            {
                c.ToTable("KerAutoKartya");
                c.HasKey(a => a.Id);
                c.Property(a => a.KerAutoTeljesId).IsRequired(true);
                c.Property(a => a.Marka).HasMaxLength(25).IsRequired(false);
                c.Property(a => a.Modell).HasMaxLength(25).IsRequired(false);
                c.Property(a => a.GyartasiEv).HasMaxLength(4).IsRequired(false);
                c.Property(a => a.Ar).IsRequired(true);
                c.Property(a => a.KilometerOraAllas).IsRequired(true);
            });

            modelBuilder.Entity<BerAuto>(c =>
            {
                c.ToTable("BerAuto");
                c.HasKey(a => a.Id);
                c.Property(a => a.Marka).HasMaxLength(25).IsRequired(true);
                c.Property(a => a.Modell).HasMaxLength(25).IsRequired(true);
                c.Property(a => a.Kivitel).HasMaxLength(50).IsRequired(true);
                c.Property(a => a.Uzemanyag).HasMaxLength(20).IsRequired(true);
                c.Property(a => a.ValtoTipus).HasMaxLength(25).IsRequired(true);
                c.Property(a => a.BerlesNapiAra).IsRequired(true);

                c.HasMany(a => a.BerFoglalasok)
                    .WithOne(b => b.BerAuto)
                    .HasForeignKey(b => b.BerAutoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(true);
            });

            modelBuilder.Entity<BerFoglalas>(c =>
            {
                c.ToTable("BerFoglalas");
                c.HasKey(a => a.Id);
                c.Property(a => a.BerAutoId).IsRequired(true);
                c.Property(a => a.TeljesNev).HasMaxLength(100).IsRequired(true);
                c.Property(a => a.TelefonSzam).HasMaxLength(16).IsRequired(true);
                c.Property(a => a.Marka).HasMaxLength(25).IsRequired(false);
                c.Property(a => a.Modell).HasMaxLength(25).IsRequired(false);
                c.Property(a => a.BerlesNapiAra).IsRequired(true);
                c.Property(a => a.AtvetelDatuma).IsRequired(true);
                c.Property(a => a.VisszaadasDatuma).IsRequired(true);
                c.Property(a => a.AtvetelHelyszine).HasMaxLength(200).IsRequired(true);
            });
        }
    }
}
