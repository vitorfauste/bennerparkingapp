using Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces.Repositories
{
    public interface IRegistroEstacionamentoRepository : IRepository<RegistroEstacionamento>
    {
        IQueryable<RegistroEstacionamento> GetAllMovimentacoes();
        IQueryable<RegistroEstacionamento> GetAllEntradas();
        RegistroEstacionamento GetByPlaca(string placa);
    }
}
