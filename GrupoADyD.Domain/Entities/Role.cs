using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Role : IdentityRole, Interfaces.IAuditable
    {
        public string Description { get; set; }

        public virtual ICollection<Access> Access { get; set; }
        public Enums.Status StatusEntity { get; set; }

        public string CreatedBy { get; set; }
        public string LastAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}