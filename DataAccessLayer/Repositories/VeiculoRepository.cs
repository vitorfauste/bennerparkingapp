using DataAccessLayer.Context;
using DataAccessLayer.Interfaces.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(EstacionamentoContext context) : base(context)
        {
        }

        public async Task<Veiculo> GetByPlaca(string placa)
        {
            return await _context.Set<Veiculo>().Where(where => where.Placa == placa).FirstOrDefaultAsync();
        }
    }
}
