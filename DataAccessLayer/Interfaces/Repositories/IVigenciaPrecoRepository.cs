﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces.Repositories
{
    public interface IVigenciaPrecoRepository : IRepository<VigenciaPreco>
    {
        Task<VigenciaPreco> GetInstance();
    }
}
