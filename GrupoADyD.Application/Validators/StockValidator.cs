using FluentValidation;

namespace GrupoADyD.Application.Validators
{
    public class StockValidator : AbstractValidator<Domain.Entities.Stock>
    {
        public StockValidator()
        {
            RuleFor(s => s.Product)
                .NotNull().NotEmpty().WithMessage("Requerido");

            RuleFor(s => s.Quantity)
                .GreaterThan(0).WithMessage("Debe ser mayor a 0");
        }
    }
}