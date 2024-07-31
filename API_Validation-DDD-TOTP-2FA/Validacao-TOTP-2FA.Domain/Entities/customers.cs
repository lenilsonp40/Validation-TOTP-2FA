using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacao_TOTP_2FA.Core.Exceptions;
using Validacao_TOTP_2FA.Domain.Validators;

namespace Validacao_TOTP_2FA.Domain.Entities
{
    public class Customers : Base
    {
        // Propriedades
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        // Campo para armazenar erros de validação
        private List<string> _errors;

        // EF
        protected Customers() { }

        public Customers(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            _errors = new List<string>();

            Validate();
        }

        // Comportamentos
        public void SetName(string name)
        {
            Name = name;
            Validate();
        }

        public void SetPassword(string password)
        {
            Password = password;
            Validate();
        }

        public void SetEmail(string email)
        {
            Email = email;
            Validate();
        }

        public override bool Validate()
        {
            var validator = new CustomersValidators();
            var validation = validator.Validate(this);

            _errors.Clear(); // Limpa os erros anteriores antes de validar novamente

            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                {
                    _errors.Add(error.ErrorMessage);
                }

                // Lançar exceção apenas se houver erros
                if (_errors.Count > 0)
                {
                    throw new DomainException("Alguns campos estão inválidos, por favor corrija-os! " + string.Join(", ", _errors));
                }
            }

            return validation.IsValid;
        }
    }
}
