using System;

namespace GrupoADyD.Domain.Entities
{
    public class CreditNote
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }
        public decimal Reduction { get; set; }

        public bool Authorized { get; set; }
        public bool Canceled { get; set; }

        public int SaleId { get; set; }
        public int AuthorizingUserId { get; set; }
        public int CanceledUserId { get; set; }
        
        public virtual Sale Sale { get; set; }
        public virtual User AuthorizingUser { get; set; }
        public virtual User CanceledUser { get; set; }

        public string WhoAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}