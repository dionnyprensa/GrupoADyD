using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Product : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public int Sold { get; set; }
        //public bool InStock { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<DetailSale> DetailSales { get; set; }
        public virtual ICollection<ProductRegistry> ProductRegistries { get; set; }
        public Enums.Status StatusEntity { get; set; }

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}