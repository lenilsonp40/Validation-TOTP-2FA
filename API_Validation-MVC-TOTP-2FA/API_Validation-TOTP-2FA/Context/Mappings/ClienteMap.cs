using API_Validation_TOTP_2FA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Validation_TOTP_2FA.Context.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.ToTable("Validation_TB001_Clientes");

            builder.HasKey(x => x.ClienteID);

            builder.HasIndex(x => x.ClienteID).IsUnique();

            builder.Property(x => x.Nome)
                    .IsRequired()
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(50)");           

            builder.Property(x => x.Email)
                    .IsRequired()
                    .HasColumnName("Email")
                    .HasColumnType("varchar(50)");
        }
    }
}
