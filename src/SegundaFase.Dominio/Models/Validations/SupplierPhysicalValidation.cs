using System;
using FluentValidation;
using SegundaFase.Business.Tools;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Models.Validations
{
    public class SupplierPhysicalValidation : AbstractValidator<SupplierPhysical>
    {
        public SupplierPhysicalValidation()
        {
            RuleFor(x => x.FullName)
                .NotEmpty()
                .WithMessage("O nome completo é obrigatorio")
                .Length(5, 100)
                .WithMessage("o campo nome deve conter entre 5 e 100 caracteres");

           
            RuleFor(x => x.CPF.IsCpf())
                .NotEmpty()
                .WithMessage("O CPF é obrigatório")
                .Equal(true)
                .WithMessage("CPF inválido");


            RuleFor(x => x.BirthDate)
                .NotEmpty()
                .WithMessage("A data de nascimento é obrigatória")
                .Must(MaiorDeIdade) //método abaixo
                .WithMessage("O fornecedor pessoa física deve ser maior de 18 anos")
                .LessThan(DateTime.Now)
                .GreaterThan(DateTime.Now.AddYears(-130));

        }

        private static bool MaiorDeIdade(DateTime BirthDate)
        {
            return BirthDate <= DateTime.Now.AddYears(-18);
        }
        
    }
}
