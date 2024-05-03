using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class EstacionamentoContext : DbContext
    {
        public EstacionamentoContext()
        {
        }

        public EstacionamentoContext(DbContextOptions<EstacionamentoContext> options) : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<TabelaPreco> TabelaPrecos { get; set; }
        public DbSet<RegistroEstacionamento> RegistroEstacionamento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vtor_\OneDrive\Documentos\ParkingAppDatabase.mdf;Integrated Security=True;Connect Timeout=30
");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RegistroEstacionamento>()
                .Property(r => r.ValorHora)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<RegistroEstacionamento>()
                .Property(r => r.ValorTotal)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<TabelaPreco>()
                .Property(t => t.ValorHora)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<TabelaPreco>()
                .Property(t => t.ValorHoraAdicional)
                .HasColumnType("decimal(18, 2)");
        }


    }
}
