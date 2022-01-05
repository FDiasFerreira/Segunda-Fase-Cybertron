using FluentValidation;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Models.Validations
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O nome da categoria é obrigatorio")
                .Length(2, 100)
                .WithMessage("o campo nome deve conter entre 2 e 100 caracteres");

            RuleFor(x => x.Active)
               .NotEmpty()
               .WithMessage("O status é obrigatorio");
        }

    }
}
