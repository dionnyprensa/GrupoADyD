using System;

namespace GrupoADyD.Domain.Interfaces
{
    public interface IAuditable
    {
        int CreatedById { get; set; }
        int ModifiedById { get; set; }

        User CreatedBy { get; set; }
        User ModifiedBy { get; set; }
        byte[] RowVersion { get; set; }
        DateTime Created { get; set; }
        DateTime Modified { get; set; }
    }
}