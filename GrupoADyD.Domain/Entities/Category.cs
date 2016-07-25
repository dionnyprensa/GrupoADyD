using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Category : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Enums.Status StatusEntity { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}