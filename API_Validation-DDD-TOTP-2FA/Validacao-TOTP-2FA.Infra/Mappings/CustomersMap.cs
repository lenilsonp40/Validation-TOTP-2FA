using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacao_TOTP_2FA.Domain.Entities;

namespace Validacao_TOTP_2FA.Infra.Mappings
{
    
    public class CustomersMap : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.ToTable("Validation_TB001_Customers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnType("BIGINT");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("name")
                .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("password")
                .HasColumnType("VARCHAR(30)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("email")
                .HasColumnType("VARCHAR(180)");


        }
    }
}
