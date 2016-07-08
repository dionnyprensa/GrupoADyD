using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;

namespace GrupoADyD.Application.Interfaces
{
    public interface IAccessService : IRepository<Access>, IAppService<Access>
    {
    }
}