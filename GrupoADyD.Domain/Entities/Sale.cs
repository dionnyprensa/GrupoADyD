using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Sale : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        public int ClientId { get; set; }
        public string UserId { get; set; }

        public virtual Client Client { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<DetailSale> DetailedSales { get; set; }

        public string WhoAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

        public Sale()
        {
            DetailedSales = new List<DetailSale>();
        }
    }
}