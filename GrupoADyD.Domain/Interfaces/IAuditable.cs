using System;

namespace GrupoADyD.Domain.Interfaces
{
    public interface IAuditable
    {
        string CreatedBy { get; set; }
        string LastAccess { get; set; }
        byte[] RowVersion { get; set; }
        DateTime Created { get; set; }
        DateTime Modified { get; set; }
    }
}