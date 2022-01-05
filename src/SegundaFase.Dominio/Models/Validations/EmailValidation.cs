using FluentValidation;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Models.Validations
{
    public class EmailValidation : AbstractValidator<Email>
    {
        public EmailValidation()
        {
            RuleFor(c => c.EmailAddress)
                .EmailAddress() //validador de email do fluent
                .WithMessage("Email inválido")
                .NotEmpty()
                .WithMessage("O campo E-mail é obrigatório")
                .Length(5, 100)
                .WithMessage("O campo E-mail precisa ter entre 5 e 100 caracteres");
        }

    }
}
