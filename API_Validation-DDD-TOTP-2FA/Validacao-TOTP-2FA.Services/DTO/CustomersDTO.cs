using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacao_TOTP_2FA.Services.DTO
{
    public class CustomersDTO
    {
        //Propriedades
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public CustomersDTO()
        { }

        public CustomersDTO(long id, string name, string email, string password)
        {
            Id = Id;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
