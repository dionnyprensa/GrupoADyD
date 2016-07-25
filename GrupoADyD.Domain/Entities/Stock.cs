using System;

namespace GrupoADyD.Domain.Entities
{
    public class Stock : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductRegistryId { get; set; }

        public virtual ProductRegistry ProductRegistry { get; set; }

        public Enums.Status StatusEntity { get; set; }

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}