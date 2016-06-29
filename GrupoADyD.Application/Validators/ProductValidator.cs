using FluentValidation;

namespace GrupoADyD.Application.Validators
{
    public class ProductValidator : AbstractValidator<Domain.Entities.Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(4, 64).WithMessage("Debe tener entre 4 y 64 letras.");

            RuleFor(p => p.Description)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerida.")
                .NotEmpty().WithMessage("Requerida.")
                .Length(128).WithMessage("Maximo 128 carecteres.");

            RuleFor(p => p.Cost)
                .GreaterThanOrEqualTo(0).WithMessage("Debe ser mayor o igual 0");

            RuleFor(p => p.Price)
                .GreaterThanOrEqualTo(0).WithMessage("Debe ser mayor o igual 0");
        }
    }
}
