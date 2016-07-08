using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;

namespace GrupoADyD.Application.Interfaces
{
    public interface ICustomerService : IRepository<Customer>, IAppService<Customer>
    {
    }
}