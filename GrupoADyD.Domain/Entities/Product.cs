using GrupoADyD.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Product : IAuditable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public int Sold { get; set; }
        public bool InStock { get; set; }
        public int Stock { get; set; }
        public Enums.Status StatusEntity { get; set; }

        public virtual ICollection<DetailSale> DetailSales { get; set; }

        public string WhoAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}