using System;

namespace GrupoADyD.Domain.Interfaces
{
    internal interface IAuditable
    {
        string WhoAccess { get; set; }
        byte[] RowVersion { get; set; }
        DateTime CreationDate { get; set; }
        DateTime ModificationDate { get; set; }
    }
}