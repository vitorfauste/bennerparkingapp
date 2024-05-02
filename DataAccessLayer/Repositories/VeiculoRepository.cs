using DataAccessLayer.Context;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class VeiculoRepository
    {
        private readonly EstacionamentoContext _db;
        public VeiculoRepository(EstacionamentoContext db)
        {
            this._db = db;
        }
    }
}
