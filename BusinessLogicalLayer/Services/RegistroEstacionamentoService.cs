using AutoMapper;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators;
using DataAccessLayer.Interfaces.Repositories;
using DataAccessLayer.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Win32;
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
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMemoryCache _memoryCache;
        private readonly IMapper _mapper;


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

        public async Task<DataResponse<RegistroEstacionamentoMapper>> GetAllMovimentacoes()
        {
            const string cacheKey = "Movimentacoes";
            var registro = new List<RegistroEstacionamento>();
            if (_memoryCache.TryGetValue(cacheKey, out List<RegistroEstacionamento> dados))
            {
                registro = dados;
            }
            else
            { registro = await _registroRepository.GetAllMovimentacoes().ToListAsync(); }

            var entidades = _mapper.Map<List<RegistroEstacionamentoMapper>>(registro);

            var cacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(3),
            };
            _memoryCache.Set(cacheKey, registro, cacheEntryOptions);


            return ResponseFactory.CreateInstance().CreateSuccessDataResponse<RegistroEstacionamentoMapper>(entidades);
        }

        public async Task<DataResponse<RegistroEstacionamentoMapper>> GetAllEntradas()
        {
            const string cacheKey = "Entradas";
            var registro = new List<RegistroEstacionamento>();
            if (_memoryCache.TryGetValue(cacheKey, out List<RegistroEstacionamento> dados))
            {
                registro = dados;
            }
            else
            { registro = await _registroRepository.GetAllEntradas().ToListAsync(); }

            var entidades = _mapper.Map<List<RegistroEstacionamentoMapper>>(registro);

            var cacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(3),
            };
            _memoryCache.Set(cacheKey, registro, cacheEntryOptions);

            return ResponseFactory.CreateInstance().CreateSuccessDataResponse<RegistroEstacionamentoMapper>(entidades);
        }
    }
}
