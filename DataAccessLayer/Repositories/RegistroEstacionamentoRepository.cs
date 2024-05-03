using DataAccessLayer.Context;
using DataAccessLayer.Interfaces.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RegistroEstacionamentoRepository : Repository<RegistroEstacionamento>, IRegistroEstacionamentoRepository
    {
        public RegistroEstacionamentoRepository(EstacionamentoContext context) : base(context)
        {
        }

        public IQueryable<RegistroEstacionamento> GetAllEntradas()
        {
            return _context.Set<RegistroEstacionamento>().Where(wh => wh.HoraSaida != null).Include(include => include.Veiculo);
        }

        public IQueryable<RegistroEstacionamento> GetAllMovimentacoes()
        {
            return _context.Set<RegistroEstacionamento>().Where(wh => wh.HoraSaida == null).Include(include => include.Veiculo);
        }

        public RegistroEstacionamento GetByPlaca(string placa)
        {
            return _context.Set<RegistroEstacionamento>().Where(wh => wh.Veiculo.Placa == placa).Include(include => include.Veiculo).FirstOrDefault();
        }
    }
}
