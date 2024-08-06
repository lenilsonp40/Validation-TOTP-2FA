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

            builder.HasKey(x => x.ClienteId);

            builder.HasIndex(x => x.ClienteId).IsUnique();

            builder.Property(x => x.Nome)
                    .IsRequired()
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(50)");           

            builder.Property(x => x.Email)
                    .IsRequired()
                    .HasColumnName("Email")
                    .HasColumnType("varchar(50)");

            builder.Property(x => x.Password)
               .IsRequired()
               .HasMaxLength(30)
               .HasColumnName("password")
               .HasColumnType("VARCHAR(30)");

            builder.Property(x => x.DataCadastro)
                    .IsRequired()
                    .HasColumnName("DataCadastro")
                    .HasColumnType("datetime");
        }
    }
}
