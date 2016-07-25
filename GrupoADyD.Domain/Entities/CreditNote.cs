using System;

namespace GrupoADyD.Domain.Entities
{
    public class CreditNote: Interfaces.IAuditable
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public bool Authorized { get; set; }
        public bool Canceled { get; set; }

        public int SaleId { get; set; }
        public int ApprovedById { get; set; }
        public int CanceledById { get; set; }
        
        public virtual Sale Sale { get; set; }
        public virtual User ApprovedBy { get; set; }
        public virtual User CanceledBy { get; set; }

        public Enums.Status StatusEntity { get; set; }

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}