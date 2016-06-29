using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;

namespace GrupoADyD.Application.Interfaces
{
    public interface IClientAppService : IRepository<Client>, IAppService<Client>
    {
    }
}