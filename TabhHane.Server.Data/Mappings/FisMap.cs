using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabhHane.Server.Data.Models;

namespace TabhHane.Server.Data.Mappings
{
    public class FisMap : IEntityTypeConfiguration<Fis>
    {
        public void Configure(EntityTypeBuilder<Fis> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FisKodu).HasMaxLength(12);
            builder.Property(p => p.FisBaglantiKodu).HasMaxLength(14);
            builder.Property(p => p.FisTuru).HasMaxLength(30);
            builder.Property(p => p.BelgeNo).HasMaxLength(20);
            builder.Property(p => p.IskontoOrani).HasPrecision(5, 2);
            builder.Property(p => p.IskontoTutar).HasPrecision(12, 2);
            builder.Property(p => p.Alacak).HasPrecision(12, 2);
            builder.Property(p => p.Borc).HasPrecision(12, 2);
            builder.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            builder.Property(p => p.Aciklama).HasMaxLength(200);

            builder.ToTable("Fisler");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.FisKodu).HasColumnName("FisKodu");
            builder.Property(p => p.FisBaglantiKodu).HasColumnName("FisBaglantiKodu");
            builder.Property(p => p.FisTuru).HasColumnName("FisTuru");
            builder.Property(p => p.CariId).HasColumnName("CariId");
            builder.Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            builder.Property(p => p.Tarih).HasColumnName("Tarih");
            builder.Property(p => p.PlasiyerId).HasColumnName("PlasiyerId");
            builder.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            builder.Property(p => p.IskontoTutar).HasColumnName("IskontoTutar");
            builder.Property(p => p.DepoId).HasColumnName("DepoId");
            builder.Property(p => p.Alacak).HasColumnName("Alacak");
            builder.Property(p => p.Borc).HasColumnName("Borc");
            builder.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");
            builder.Property(p => p.BankaId).HasColumnName("BankaId");


            builder.HasOne(c => c.Cari).WithMany(c => c.Fis).HasForeignKey(c => c.CariId);
            builder.HasOne(c => c.Banka).WithMany(c => c.Fis).HasForeignKey(c => c.BankaId);
            builder.HasOne(c => c.Personel).WithMany(c => c.Fis).HasForeignKey(c => c.PlasiyerId);
            builder.HasOne(c => c.Depo).WithMany(c => c.Fisler).HasForeignKey(c => c.DepoId);
        }
    }
}
