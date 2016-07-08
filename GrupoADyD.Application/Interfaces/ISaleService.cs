using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;

namespace GrupoADyD.Application.Interfaces
{
    public interface ISaleService : IRepository<Sale>, IAppService<Sale>
    {
    }
}