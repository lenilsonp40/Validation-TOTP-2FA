using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacao_TOTP_2FA.Domain.Entities;

namespace Validacao_TOTP_2FA.Infra.Interfaces
{    

    public interface ICustomersRepository : IBaseRepository<Customers>
    {
        Task<Customers> GetByEmail(string email);
        Task<List<Customers>> SearchByEmail(string email);
        Task<List<Customers>> SearchByName(string name);

    }
}
