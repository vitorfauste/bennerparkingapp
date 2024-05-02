using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RegistroEstacionamento : BaseEntity
    {
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; set; }
        public Veiculo Veiculo { get; set; }
        public decimal ValorHora { get; set; }
        public decimal? ValorTotal { get; set; }

        public RegistroEstacionamento(DateTime horarioEntrada, decimal valorHora, Veiculo veiculo)
        {
            this.HoraEntrada = horarioEntrada;
            this.ValorHora = valorHora;
            this.Veiculo = veiculo;
        }

        // VERIFICAR NA HORA DE FAZER A TELA
        public decimal CalcularValorTotal(string? entrada, DateTime horaSaida, string? valorHora)
        {
            DateTime horaEntrada = Convert.ToDateTime(entrada);
            var diferenca = horaSaida - horaEntrada;
            if (Math.Round(diferenca.TotalHours, MidpointRounding.ToZero) == 0 && Math.Round(diferenca.TotalMinutes, MidpointRounding.ToZero) <= 30)
            {
                return (Convert.ToDecimal(valorHora) / 2);
            }
            else
            {
                if ((Convert.ToDecimal(diferenca.TotalMinutes) - (Convert.ToDecimal(Math.Round(diferenca.TotalHours, MidpointRounding.ToZero)) * 60)) <= 10)
                {
                    return (Convert.ToDecimal(valorHora) * Convert.ToDecimal(Math.Round(diferenca.TotalHours, MidpointRounding.ToZero)));
                }
                else
                {
                    return (Convert.ToDecimal(valorHora) * (Convert.ToDecimal(Math.Round(diferenca.TotalHours, MidpointRounding.ToZero)) + 1));
                }
            }
        }
    }
}
