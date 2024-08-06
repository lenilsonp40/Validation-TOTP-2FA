using API_Validation_TOTP_2FA.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace API_Validation_TOTP_2FA.Context.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoModel>
    {
        public void Configure(EntityTypeBuilder<ProdutoModel> builder)
        {

            builder.ToTable("Validation_TB002_Produtos");

            builder.HasKey(x => x.ProdutoId);

            builder.HasIndex(x => x.ProdutoId).IsUnique();

            builder.Property(x => x.Nome)
                    .IsRequired()
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(50)");

            builder.Property(x => x.Descricao)
               .IsRequired()
               .HasColumnName("Descricao")
               .HasColumnType("varchar(100)");

            builder.Property(x => x.Preco)
                    .IsRequired()
                    .HasColumnName("Preco")
                    .HasColumnType("decimal(10, 2)");

            builder.Property(x => x.ImagemUrl)
                    .IsRequired()
                    .HasColumnName("ImagemUrl")
                    .HasColumnType("varchar(200)");

            builder.Property(x => x.Estoque)
                    .IsRequired()
                    .HasColumnName("Estoque")
                    .HasColumnType("float");

            builder.Property(x => x.DataCadastro)
                    .IsRequired()
                    .HasColumnName("DataCadastro")
                    .HasColumnType("datetime");

        }
    }

    }
