﻿using System;
using System.Collections.Generic;

namespace GrupoADyD.Domain.Entities
{
    public class Customer : Interfaces.IAuditable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identification { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public decimal Discount { get; set; }
        public bool OnCredit { get; set; }
        public bool HasAccountsReceivable { get; set; }
        public bool HasCreditNotes { get; set; }

        public Enums.CustomerType CustomerType { get; set; }

        public virtual ICollection<Sale> Purchases { get; set; }
        public virtual ICollection<AccountsReceivable> AccountsReceivable { get; set; }
        public virtual ICollection<CreditNote> CreditNotes { get; set; }

        public Enums.Status StatusEntity { get; set; }
        public string WhoAccess { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}