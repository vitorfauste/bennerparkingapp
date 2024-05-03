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
    }
}
