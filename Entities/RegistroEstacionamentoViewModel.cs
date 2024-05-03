using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RegistroEstacionamentoViewModel
    {
        public string PlacaCarro { get; set; }
        public string? ValorHora { get; set; }

        public string? ValorTotal { get; set; }

        public string? HoraEntrada { get; set; }

        public string? HoraSaida { get; set; }

        public string? Duracao { get; set; }
        public string? TempoCobrado { get; set; }
    }
}
