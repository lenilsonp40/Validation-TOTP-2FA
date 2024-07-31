using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Validacao_TOTP_2FA.Domain.Entities;
using Validacao_TOTP_2FA.Infra.Mappings;

namespace Validacao_TOTP_2FA.Infra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public virtual DbSet<Customers> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CustomersMap());
        }


        //retirar essa parte daqui depois de utilizar no mapeamento do banco de dados:

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LENILSONNOTE\SQLEXPRESS;Initial Catalog=Validation-TOTP-2FA;Integrated Security=True;TrustServerCertificate=True;");
            }
        }
        */
    }
}
