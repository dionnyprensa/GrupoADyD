using FluentValidation.Results;
using System.Collections.Generic;

namespace GrupoADyD.Application.Interfaces
{
    public interface IAppService<T> where T: class
    {
        bool isValid(T entity);
        ICollection<ValidationFailure> Errors(T entity);
    }
}