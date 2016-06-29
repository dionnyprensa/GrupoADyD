using FluentValidation;

namespace GrupoADyD.Application.Validators
{
    public class UserValidator : AbstractValidator<Domain.Entities.User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(4, 32).WithMessage("Debe tener entre 4 y 32 letras.");

            RuleFor(u => u.LastName)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(4, 64).WithMessage("Debe tener entre 4 y 64 letras.");
        }
    }
}