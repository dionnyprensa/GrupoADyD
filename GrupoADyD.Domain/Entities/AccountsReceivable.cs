using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class AccountsReceivable: Interfaces.IAuditable
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<DetailAccountsReceivable> DetailsAccountsReceivable { get; set; }

        public decimal Amount {
            get
            {
                decimal _amount = 0;
                foreach (var item in DetailsAccountsReceivable)
                {
                    _amount = item.Due;
                }
                return _amount;
            }
            private set
            {
                Amount = value;
            }
        }
        public Enums.Status StatusEntity { get; set; }

        public string CreatedBy { get; set; }
        public string LastAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}