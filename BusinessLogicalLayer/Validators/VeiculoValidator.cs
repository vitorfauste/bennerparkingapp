using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace BusinessLogicalLayer.Validators
{
    public class VeiculoValidator : AbstractValidator<Veiculo>
    {
        public VeiculoValidator() 
        {
            RuleFor(v => v.Id).GreaterThan(0);
            RuleFor(v => v.Placa).NotEmpty();
            RuleFor(v => v.Placa).MaximumLength(8);
            RuleFor(v => v.Placa).MinimumLength(7);
        }
    }
}
