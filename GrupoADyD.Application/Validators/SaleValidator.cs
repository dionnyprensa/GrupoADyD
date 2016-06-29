using FluentValidation;

namespace GrupoADyD.Application.Validators
{
    public class SaleValidator : AbstractValidator<Domain.Entities.Sale>
    {
        public SaleValidator()
        {
            RuleFor(s => s.Discount)
                .GreaterThanOrEqualTo(0).WithMessage("Debe ser mayor o igual 0");

            RuleFor(s => s.ClientId)
                .NotNull().NotEmpty().WithMessage("Requerido");

            RuleFor(s => s.Client)
                .NotNull().NotEmpty().WithMessage("Requerido");
        }
    }
}
