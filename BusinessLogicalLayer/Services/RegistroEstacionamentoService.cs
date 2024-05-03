using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators;
using DataAccessLayer.Interfaces.Repositories;
using DataAccessLayer.Repositories;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Services
{
    public class RegistroEstacionamentoService : IRegistroEstacionamentoService
    {
        private readonly IRegistroEstacionamentoRepository _registroRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RegistroEstacionamentoService(IRegistroEstacionamentoRepository registroRepository)
        {
            _registroRepository = registroRepository;
        }

        public async Task<Response> Create(RegistroEstacionamento registro)
        {
            VeiculoValidator veiculoValidator = new VeiculoValidator();
            registro.Veiculo = new Veiculo(registro.Veiculo.Placa);
            veiculoValidator.Validate(registro.Veiculo);
            try
            {
                _registroRepository.Create(registro);
                _unitOfWork.Commit();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailResponse(ex.Message);
            }
        }

        public Task<Response> UpdateRegistro(string placa, DateTime now, decimal valorHora)
        {
            throw new NotImplementedException();
        }
    }
}
