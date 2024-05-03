using AutoMapper;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RegistroEstacionamentoMapper : Profile
    {
        public RegistroEstacionamentoMapper()
        {
            CreateMap<RegistroEstacionamento, RegistroEstacionamentoViewModel>()
                .ForMember(dest => dest.PlacaCarro, opt => opt.MapFrom(src => src.Veiculo.Placa))
                .ForMember(dest => dest.Duracao, opt => opt.MapFrom(src => (src.HoraSaida - src.HoraEntrada).ToString()))
                .ForMember(dest => dest.TempoCobrado, opt => opt.MapFrom(src => GetTempoCobrado(src.ValorHora, src.ValorTotal)))
                .ForMember(dest => dest.ValorHora, opt => opt.MapFrom(src => src.ValorHora.ToString("0.00")))
                .ForMember(dest => dest.ValorTotal, opt => opt.MapFrom(src => src.ValorTotal.HasValue ? src.ValorTotal.Value.ToString("0.00") : ""))
                .ReverseMap()
                .ForPath(dest => dest.Veiculo.Placa, opt => opt.MapFrom(src => src.PlacaCarro.Replace("-", "").ToUpper()));
        }
        public static string GetTempoCobrado(decimal valorHora, decimal? valorTotal)
        {
            if (!valorTotal.HasValue)
                return "";
            return (valorTotal / valorHora).ToString();
        }
    }
    
}
