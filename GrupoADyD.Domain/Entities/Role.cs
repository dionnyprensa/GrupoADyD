using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Role : IdentityRole, Interfaces.IAuditable
    {
        public string Description { get; set; }

        public virtual ICollection<Access> Access { get; set; }

        public string WhoAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}