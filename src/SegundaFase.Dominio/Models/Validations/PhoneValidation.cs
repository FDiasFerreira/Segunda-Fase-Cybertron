using FluentValidation;
using SegundaFase.Business.Models.Enums;
using SegundaFase.WebApp.Models;


namespace SegundaFase.Business.Models.Validations
{
    public class PhoneValidation : AbstractValidator<Phone>
    {
        public PhoneValidation()
        {
            RuleFor(x => x.Ddd)
                  .NotEmpty()
                  .WithMessage("O ddd é obrigatorio")
                  .Length(2, 2)
                  .WithMessage("o ddd deve conter 2 caracteres");

            When(x => x.PhoneType == PhoneType.SmarthPhone, () =>
            {
                RuleFor(x => x.Number)
                   .NotEmpty()
                   .WithMessage("O celular é obrigatorio")
                   .Length(9, 9)
                   .WithMessage("o celular deve conter 9 caracteres");
            });

            When(x => x.PhoneType == PhoneType.Home, () =>
            {
                RuleFor(x => x.Number)
                   .NotEmpty()
                   .WithMessage("O telefone fixo é obrigatorio")
                   .Length(8, 8)
                   .WithMessage("o telefone fixo deve conter 8 caracteres");
            });

            When(x => x.PhoneType == PhoneType.Commercial, () =>
            {
                RuleFor(x => x.Number)
                   .NotEmpty()
                   .WithMessage("O telefone comercial é obrigatorio")
                   .Length(8, 9)
                   .WithMessage("o telefone comercial deve conter entre 8 e 9 caracteres");
            });

        }
    }
}
