using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class AccountsReceivable
    {
        public int Id { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<DetailAccountsReceivable> DetailsAccountsReceivable { get; set; }

        public decimal Amount {
            get
            {
                decimal amount = 0;
                foreach (var item in DetailsAccountsReceivable)
                {
                    amount = item.Due;
                }
                return amount;
            }
            private set
            {
                Amount = value;
            }

        }
    }
}