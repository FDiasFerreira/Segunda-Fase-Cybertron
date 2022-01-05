using FluentValidation;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Models.Validations
{
    public class AddressValidation : AbstractValidator<Address>
    {
        public AddressValidation()
        {
            RuleFor(c => c.ZipCode)
                .Must(ValidaCep) // método abaixo
                .NotEmpty()
                .WithMessage("O campo CEP precisa ser fornecido")
                .Length(9)//9 por causa do traço -
                .WithMessage("O campo CEP precisa ter 9 caracteres");

            RuleFor(c => c.Street)
                .NotEmpty()
                .WithMessage("O campo Rua precisa ser fornecido")
                .Length(5, 200)
                .WithMessage("O campo Rua precisa ter entre 5 e 200 caracteres");
           
            RuleFor(c => c.Number)
                .NotEmpty()
                .WithMessage("O campo número precisa ser fornecido")
                .Length(1, 10)
                .WithMessage("O campo número precisa ter entre 1 e 10 caracteres");
            
            RuleFor(c => c.Neighborhood)
                .NotEmpty()
                .WithMessage("O campo bairro precisa ser fornecido")
                .Length(2, 50)
                .WithMessage("O campo bairro precisa ter entre 2 e 50 caracteres");
            
            RuleFor(c => c.City)
                .NotEmpty()
                .WithMessage("A campo cidade precisa ser fornecida")
                .Length(2, 50)
                .WithMessage("O campo cidade precisa ter entre 2 e 50 caracteres");

            RuleFor(c => c.State)
                .NotEmpty()
                .WithMessage("O campo estado precisa ser fornecido")
                .Length(2, 50)
                .WithMessage("O campo estado precisa ter entre 2 e 50 caracteres");

           
        }
        public static bool ValidaCep(string zipCode)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(zipCode,
                ("[0-9]{5}-[0-9]{3}"));
        }

    }
}
