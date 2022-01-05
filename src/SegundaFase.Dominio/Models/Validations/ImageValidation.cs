using FluentValidation;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Models.Validations
{
    public class ImageValidation : AbstractValidator<Image>
    {
        public ImageValidation()
        {
            RuleFor(x => x.ImagePath)
                .NotEmpty()
                .WithMessage("O nome é obrigatorio")
                .Length(2, 100)
                .WithMessage("o campo nome deve conter entre 2 e 100 caracteres");
        }
    }
}
