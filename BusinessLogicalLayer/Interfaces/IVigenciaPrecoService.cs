using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IVigenciaPrecoService
    {
        public Task<Response> Create(VigenciaPreco vigencia);
        public Task<Response> UpdateInstance(VigenciaPreco vigencia);

        public Task<SingleResponse<VigenciaPreco>> GetInstance();
    }
}
