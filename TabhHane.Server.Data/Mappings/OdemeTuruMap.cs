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
    public class OdemeTuruMap : IEntityTypeConfiguration<OdemeTuru>
    {
        public void Configure(EntityTypeBuilder<OdemeTuru> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.OdemeTuruAdi).HasMaxLength(30);
            builder.Property(p => p.OdemeTuruKodu).HasMaxLength(12);
            builder.Property(p => p.Aciklama).HasMaxLength(200);

            builder.ToTable("OdemeTurleri");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            builder.Property(p => p.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
