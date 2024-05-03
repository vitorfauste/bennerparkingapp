using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces.Repositories
{
    public interface IVeiculoRepository : IRepository<Veiculo>
    {
        Task<Veiculo> GetByPlaca(string placa);
    }
}
