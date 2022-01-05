using FluentValidation;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Business.Models.Validations
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O nome do produto é obrigatorio")
                .Length(2, 200)
                .WithMessage("o campo nome deve conter entre 2 e 200 caracteres");

            RuleFor(x => x.BarCode)
                .NotEmpty()
                .WithMessage("O código de barras é obrigatorio")
                .Length(13)
                .WithMessage("o campo nome deve conter 13 caracteres");

            RuleFor(x => x.QuantityStock)
                .NotEmpty()
                .WithMessage("A quantidade de itens no estoque é obrigatoria");

            RuleFor(x => x.Active)
                .NotEmpty()
                .WithMessage("O status é obrigatorio");

            RuleFor(x => x.PriceSales)
                .NotEmpty()
                .WithMessage("O preço de venda é obrigatorio");

            RuleFor(x => x.PricePurchase)
                .NotEmpty()
                .WithMessage("O preço de compra é obrigatorio");

        }
        
    }
}
