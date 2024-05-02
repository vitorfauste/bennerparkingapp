using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class EstacionamentoContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<TabelaPreco> TabelaPrecos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vtor_\OneDrive\Documentos\ParkingAppDB.mdf;Integrated Security=True;Connect Timeout=60");
            }
        }
    }

}
