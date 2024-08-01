using API_Validation_TOTP_2FA.Context.Mappings;
using API_Validation_TOTP_2FA.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Validation_TOTP_2FA.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            

        }
        public DbSet<ClienteModel> cliente { get; set; }
       

    }
}
