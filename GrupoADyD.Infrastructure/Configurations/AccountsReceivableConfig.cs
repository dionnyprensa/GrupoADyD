﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GrupoADyD.Infrastructure.Configurations
{
    public class AccountsReceivableConfig : EntityTypeConfiguration<Domain.Entities.AccountsReceivable>
    {
        public AccountsReceivableConfig()
        {
            ToTable("AccountsReceivable");

            HasKey(a => a.Id);

            Property(ar => ar.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(ar => ar.Amount)
                .HasPrecision(18, 2)
                .IsRequired();

            Property(ar => ar.CustomerId)
                .IsRequired();

            Property(ar => ar.UserId)
                .IsRequired();

            Property(a => a.RowVersion)
                .HasColumnType("timestamp")
                .IsConcurrencyToken();
        }
    }
}