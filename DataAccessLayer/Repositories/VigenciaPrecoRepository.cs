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
    public class VigenciaPrecoRepository : Repository<VigenciaPreco>, IVigenciaPrecoRepository
    {
        public VigenciaPrecoRepository(EstacionamentoContext context) : base(context)
        {
        }

        public async Task<VigenciaPreco> GetInstance()
        {
            return await _context.Set<VigenciaPreco>().FirstOrDefaultAsync();
        }
    }
}
