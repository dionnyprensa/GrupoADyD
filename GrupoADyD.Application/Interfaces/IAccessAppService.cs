using GrupoADyD.Domain.Entities;
using GrupoADyD.Domain.Interfaces;

namespace GrupoADyD.Application.Interfaces
{
    public interface IAccessAppService : IRepository<Access>, IAppService<Access>
    {
    }
}