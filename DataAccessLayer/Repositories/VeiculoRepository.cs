using DataAccessLayer.Context;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class VeiculoRepository
    {
        EstacionamentoContext db = new EstacionamentoContext();
        Veiculo veiculo = new Veiculo();   
        db.Veiculos.Add(veiculo);
        db.SaveChanges;
    }
}
