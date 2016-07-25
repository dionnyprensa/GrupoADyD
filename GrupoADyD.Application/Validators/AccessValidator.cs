using FluentValidation;

namespace GrupoADyD.Application.Validators
{
    public class AccessValidator : AbstractValidator<Domain.Entities.Access>
    {
        public AccessValidator()
        {
            RuleFor(a => a.Name)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(4, 16).WithMessage("Debe tener entre 4 y 16 letras.");
                
            RuleFor(a => a.Description)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerida.")
                .NotEmpty().WithMessage("Requerida.")
                .Length(128).WithMessage("Maximo 128 carecteres.");
        }
    }
}