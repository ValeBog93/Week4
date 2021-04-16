using Esercitzione4.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitzione4.EF
{
    public class OrdineConfiguration : IEntityTypeConfiguration<Ordine>
    {
        public void Configure(EntityTypeBuilder<Ordine> builder)
        {
            builder.HasKey(e => e.Id);
            builder
                .Property(e => e.DataOrdine)
                .IsRequired();

            builder
                .Property(e => e.CodiceOrdine)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(e => e.CodiceProdotto)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(e => e.Importo)
                .HasDefaultValue(0)
                .IsRequired();

            builder
                .HasOne(e => e.Cliente)
                .WithMany(c => c.Ordini);
          
        }
    }
}
