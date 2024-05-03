using Entities;
using Microsoft.Win32;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IRegistroEstacionamentoService
    {
        public Task<Response> Create(RegistroEstacionamento registro);

        public Task<Response> UpdateRegistro(string placa, DateTime now, decimal valorHora);
    }
}
