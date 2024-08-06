using API_Validation_TOTP_2FA.Context.Mappings;
using API_Validation_TOTP_2FA.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Validation_TOTP_2FA.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());

        }
        public DbSet<ClienteModel>? Clientes { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }


    }
}
