using FluentValidation;

namespace GrupoADyD.Application.Validators
{
    public class RoleValidator : AbstractValidator<Domain.Entities.Role>
    {
        public RoleValidator()
        {
            RuleFor(r => r.Description)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerida.")
                .NotEmpty().WithMessage("Requerida.")
                .Length(128).WithMessage("Maximo 128 carecteres.");
        }
    }
}
