using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VigenciaPreco : BaseEntity
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public decimal ValorHora { get; set; }

        public void UpdateVigenceItens(VigenciaPreco vigencia)
        {
            this.Inicio = vigencia.Inicio;
            this.Fim = vigencia.Fim;
            this.ValorHora = vigencia.ValorHora;

        }
    }
}
