using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Sale : Interfaces.IAuditable
    {
        public Sale()
        {
            DetailedSales = new List<DetailSale>();
            Discount = new decimal();
            SubTotal = new decimal();
            Total = new decimal();
            Paid = new decimal();
        }

        public int Id { get; set; }
        public decimal Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total {
            get { return (SubTotal - Discount); }
            private set { Total = value; }
        }
        public decimal Paid { get; set; }
        public decimal? Due { get; set; }

        public bool HasAccountReceivable { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsCreditNote { get; set; }

        public Enums.PurchaseType TypePurchase { get; set; }
        public Enums.MethodPayment PaymentMethod { get; set; }
        public Enums.Status StatusEntity { get; set; }

        public int CustomerId { get; set; }
        public int CreditNoteId { get; set; }
        public int AccountsReceivableId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CreditNote CreditNote { get; set; }
        public virtual ICollection<DetailSale> DetailedSales { get; set; }
        public virtual AccountsReceivable AccountsReceivable { get; set; }

        //Auditoria
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual User ModifiedBy { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}