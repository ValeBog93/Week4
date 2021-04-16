using Esercitzione4.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Esercitzione4.EF
{
    public class OrdineContext : DbContext
    {
        public DbSet<Ordine> Ordini { get; set; }
        public DbSet<Cliente> Clienti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBilder)
        {

            string connectionString = "Server = WINAPFC01X4OMES; Database = GestioneOrdiniClienti; Integrated Security = true ";
            optionsBilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Ordine>(new OrdineConfiguration());
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());

        }
    }
}
