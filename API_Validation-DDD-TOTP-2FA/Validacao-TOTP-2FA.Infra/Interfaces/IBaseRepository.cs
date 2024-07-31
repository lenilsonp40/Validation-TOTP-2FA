using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacao_TOTP_2FA.Domain.Entities;

namespace Validacao_TOTP_2FA.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<T> CreateAsync(T obj);
        Task<T> UpdateAsync(T obj);
        Task RemoveAsync(long id);
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(long id);

    }
}
