using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Models.Validations
{
    public class SupplierValidation : AbstractValidator<Supplier>
    {
        public SupplierValidation()
        {
            RuleFor(x => x.FantasyName)
            .NotEmpty()
            .WithMessage("O nome fantasia é obrigatório")
            .Length(5, 100)
            .WithMessage("O nome fantasia deve ter entre 5 e 100 caracteres");
        }
    }
}
