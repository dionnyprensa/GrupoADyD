using FluentValidation;

namespace GrupoADyD.Application.Validators
{
    public class ClientValidator : AbstractValidator<Domain.Entities.Client>
    {
        public ClientValidator()
        {
            RuleFor(a => a.FirstName)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(4, 32).WithMessage("Debe tener entre 4 y 32 letras.");

            RuleFor(a => a.LastName)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .Length(4, 64).WithMessage("Debe tener entre 4 y 64 letras.");

            RuleFor(a => a.Phone)
                .Matches(@"^([0-9])+\w$").WithMessage("Solo numeros.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(10, 10).WithMessage("Debe tener entre 10 numeros.");

            RuleFor(a => a.Address)
                .NotNull().WithMessage("Requerida.")
                .NotEmpty().WithMessage("Requerida.")
                .Length(16, 16).WithMessage("Debe tener entre 16 y 64 caracteres.");

            RuleFor(a => a.Discount)
                .GreaterThanOrEqualTo(0).WithMessage("Debe ser mayor o igual 0");
        }
    }
}
