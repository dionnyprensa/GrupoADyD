using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;

namespace GrupoADyD.Application.Interfaces
{
    public interface ISaleAppService : IRepository<Sale>, IAppService<Sale>
    {
    }
}