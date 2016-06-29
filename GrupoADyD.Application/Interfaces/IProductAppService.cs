using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;

namespace GrupoADyD.Application.Interfaces
{
    public interface IProductAppService : IRepository<Product>, IAppService<Product>
    {
    }
}