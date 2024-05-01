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
            optionsBuilder.UseSqlite("Filename=MeuBancoDeDados.db");
        }
    }

}
