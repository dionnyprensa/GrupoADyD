using GrupoADyD.Domain.Enums;
using System;

namespace GrupoADyD.Domain.Interfaces
{
    public interface IAuditable
    {
        string WhoAccess { get; set; }
        byte[] RowVersion { get; set; }
        DateTime CreationDate { get; set; }
        DateTime ModificationDate { get; set; }
        Status StatusEntity { get; set; }
    }
}