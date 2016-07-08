using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;

namespace GrupoADyD.Application.Interfaces
{
    public interface IProductService : IRepository<Product>, IAppService<Product>
    {
    }
}