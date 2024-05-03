using BusinessLogicalLayer.Interfaces;
using DataAccessLayer.Context;
using DataAccessLayer.Interfaces.Repositories;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Services
{
    public class VigenciaPrecoService : IVigenciaPrecoService
    {
        private readonly IVigenciaPrecoRepository _vigenciaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public VigenciaPrecoService(IUnitOfWork unitOfWork, IVigenciaPrecoRepository vigenciaRepository)
        {
            this._vigenciaRepository = vigenciaRepository;
            this._unitOfWork = unitOfWork;
        }
        public async Task<Response> Create(VigenciaPreco vigencia)
        {
            if (vigencia.Inicio >= vigencia.Fim)
            {
                return ResponseFactory.CreateInstance().CreateFailResponse("O início da vigência deve ser anterior ao final.");
            }

            try
            {
                _vigenciaRepository.Create(vigencia);
                _unitOfWork.Commit();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailResponse(ex.Message);
            }
        }

        public async Task<SingleResponse<VigenciaPreco>> GetInstance()
        {
            try
            {
                var vigencia = await _vigenciaRepository.GetInstance();

                if (vigencia == null)
                {
                    return ResponseFactory.CreateInstance().CreateFailSingleResponse<VigenciaPreco>("VigenciaPreco not found.", null);
                }

                return ResponseFactory.CreateInstance().CreateSuccessSingleResponse<VigenciaPreco>(vigencia);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailSingleResponse<VigenciaPreco>(ex.Message, null);
            }
        }


        public async Task<Response> UpdateInstance(VigenciaPreco vigencia)
        {
            if (vigencia.Inicio >= vigencia.Fim)
            {
                return ResponseFactory.CreateInstance().CreateFailResponse("O início da vigência deve ser anterior ao final.");
            }

            try
            {
                var singleVigence = await GetInstance();

                if (singleVigence.HasSuccess && singleVigence.Item != null)
                {
                    var vigence = singleVigence.Item;
                    vigence.UpdateVigenceItens(vigencia);

                    _vigenciaRepository.Update(vigence);
                    _unitOfWork.Commit();
                    return ResponseFactory.CreateInstance().CreateSuccessResponse();
                }
                else
                {
                    // Handle case where VigenciaPreco is not found or is invalid
                    return ResponseFactory.CreateInstance().CreateFailResponse("VigenciaPreco não encontrada ou inválida.");
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                return ResponseFactory.CreateInstance().CreateFailResponse("Ocorreu um erro ao atualizar a vigência: " + ex.Message);
            }
        }


    }
}
