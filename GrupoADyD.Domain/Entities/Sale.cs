using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Sale : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public decimal Discount { get; set; }
        public decimal Amount { get; set; }
        public decimal Total {
            get { return (Amount - Discount); }
            private set { }
        }
        public decimal Paid { get; set; }

        public bool HasAccountReceivable { get; set; }

        public bool Canceled { get; set; }
        
        public Enums.PurchaseType TypePurchase { get; set; }
        public Enums.MethodPayment PaymentMethod { get; set; }

        public int CustomerId { get; set; }
        public string UserId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<DetailSale> DetailedSales { get; set; }
        public virtual ICollection<AccountsReceivable> AccountsReceivable { get; set; }

        public Enums.Status StatusEntity { get; set; }
        public string WhoAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

        public Sale()
        {
            DetailedSales = new List<DetailSale>();
            Discount = new decimal();
            Amount = new decimal();
        }
    }
}