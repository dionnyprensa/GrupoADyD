﻿using System;
namespace GrupoADyD.Domain.Entities
{
    public class ProductMeasure: Interfaces.IAuditable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int QuantityByUnitMesuare { get; set; }
        public Enums.Status StatusEntity { get; set; }

        public string WhoAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}