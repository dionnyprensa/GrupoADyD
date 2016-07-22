﻿using System;

namespace GrupoADyD.Domain.Entities
{
    public class ProductRegistry: Interfaces.IAuditable
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        public int ProductId { get; set; }
        public int ProductMeasureId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductMeasure ProductMeasure { get; set; }
        public Enums.Status StatusEntity { get; set; }

        public string CreatedBy { get; set; }
        public string LastAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}