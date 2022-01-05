using System.Collections.Generic;
using FluentValidation;
using SegundaFase.Business.Tools;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Models.Validations
{
    public class SupplierJuridicalValidation : AbstractValidator<SupplierJuridical>
    {
               
        public SupplierJuridicalValidation()
        {
            RuleFor(x => x.CompanyName)
                .NotEmpty()
                .WithMessage("O nome da empresa é obrigatorio")
                .Length(5, 200)
                .WithMessage("o campo nome deve conter entre 5 e 200 caracteres");

         
            RuleFor(x => x.CNPJ.IsCnpj())
                .NotEmpty()
                .WithMessage("O CNPJ é obrigatório")
                .Equal(true)
                .WithMessage("CNPJ inválido");
        }

      
    }
}
