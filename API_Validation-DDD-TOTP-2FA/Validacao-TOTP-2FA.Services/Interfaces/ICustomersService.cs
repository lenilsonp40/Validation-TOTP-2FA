using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacao_TOTP_2FA.Services.DTO;

namespace Validacao_TOTP_2FA.Services.Interfaces
{
    public interface ICustomersService
    {
        Task<CustomersDTO> Create(CustomersDTO customersDTO);
        Task<CustomersDTO> Update(CustomersDTO customersDTO);
        Task Remove(long Id);
        Task<CustomersDTO> Get(long Id);
        Task<List<CustomersDTO>> Get();
        Task<List<CustomersDTO>> SearchByName(string name);
        Task<List<CustomersDTO>> SearchByEmail(string email);
        Task<CustomersDTO> GetByEmail(string email);
    }
}
