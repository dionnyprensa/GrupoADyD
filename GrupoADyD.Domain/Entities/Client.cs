using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Client : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal Discount { get; set; }
        public bool ToCost { get; set; }

        public virtual ICollection<Sale> Purchases { get; set; }

        public string WhoAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}