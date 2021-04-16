using Esercitzione4.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitzione4.EF
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.CodiceCliente)
                .HasColumnType("CodiceCliente")
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(c=>c.Nome)
                .HasColumnName("Nome")
                 .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(c=>c.Cognome)
                .HasColumnType("Cognome")
                 .HasMaxLength(50)
                .IsRequired();
            builder
                .HasMany(c => c.Ordini)
                .WithOne(c => c.Cliente);
        }
    }
}
