using Microsoft.EntityFrameworkCore;
using Validacao_TOTP_2FA.Domain.Entities;
using Validacao_TOTP_2FA.Infra.Context;
using Validacao_TOTP_2FA.Infra.Interfaces;

namespace Validacao_TOTP_2FA.Infra.Repositories
{

    public class CustomersRepository : BaseRepository<Customers>, ICustomersRepository
    {
        private readonly AppDbContext _context;

        public CustomersRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Customers> GetByEmail(string email)
        {
            var user = await _context.Users
                                    .Where
                                    (
                                        x =>
                                            x.Email.ToLower() == email.ToLower()

                                    )
                                    .AsNoTracking()
                                    .ToListAsync();

            return user.FirstOrDefault();
        }

        public async Task<List<Customers>> SearchByEmail(string email)
        {
            var allUser = await _context.Users
                                    .Where
                                    (
                                        x =>
                                            x.Email.ToLower().Contains(email.ToLower())

                                    )
                                    .AsNoTracking()
                                    .ToListAsync();

            return allUser;
        }

        public async Task<List<Customers>> SearchByName(string name)
        {
            var allUser = await _context.Users
                                    .Where
                                    (
                                        x =>
                                            x.Name.ToLower().Contains(name.ToLower())

                                    )
                                    .AsNoTracking()
                                    .ToListAsync();

            return allUser;
        }
    }
}
