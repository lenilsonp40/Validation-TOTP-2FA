using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacao_TOTP_2FA.Core.Exceptions;
using Validacao_TOTP_2FA.Domain.Entities;
using Validacao_TOTP_2FA.Infra.Interfaces;
using Validacao_TOTP_2FA.Services.DTO;
using Validacao_TOTP_2FA.Services.Interfaces;

namespace Validacao_TOTP_2FA.Services.Services
{
    public class CustomersService : ICustomersService
    {
        private readonly IMapper _mapper;
        private readonly ICustomersRepository _customersRepository;

        public CustomersService(IMapper mapper, ICustomersRepository customersRepository)
        {
            _mapper = mapper;
            _customersRepository = customersRepository;
        }

        public async Task<CustomersDTO> Create(CustomersDTO customersDTO)
        {
            var customersExists = await _customersRepository.GetByEmail(customersDTO.Email);

            if (customersExists != null)
                throw new DomainException("Já existe um usuário cadastrado com o email informado.");

            var customers = _mapper.Map<Customers>(customersDTO);
            customers.Validate();

            var customersCreated = await _customersRepository.CreateAsync(customers);

            return _mapper.Map<CustomersDTO>(customersCreated);
        }

        public async Task<CustomersDTO> Update(CustomersDTO customersDTO)
        {
            var customersExists = await _customersRepository.GetAsync(customersDTO.Id);

            if (customersExists != null)
                throw new DomainException("Não existe nenhum usuário com o id informado.");

            var customers = _mapper.Map<Customers>(customersDTO);
            customers.Validate();

            var customersUpdated = await _customersRepository.UpdateAsync(customers);

            return _mapper.Map<CustomersDTO>(customersUpdated);
        }

        public async Task Remove(long Id)
        {
            await _customersRepository.RemoveAsync(Id);
        }

        public async Task<CustomersDTO> Get(long Id)
        {
            var customers = await _customersRepository.GetAllAsync();

            return _mapper.Map<CustomersDTO>(customers);
        }

        public async Task<List<CustomersDTO>> Get()
        {
            var allCustomers = await _customersRepository.GetAllAsync();

            return _mapper.Map<List<CustomersDTO>>(allCustomers);
        }

        public async Task<CustomersDTO> GetByEmail(string email)
        {
            var customers = await _customersRepository.GetByEmail(email);

            return _mapper.Map<CustomersDTO>(customers);
        }       

        public async Task<List<CustomersDTO>> SearchByEmail(string email)
        {
            var allCustomers = await _customersRepository.SearchByEmail(email);

            return _mapper.Map<List<CustomersDTO>>(allCustomers);
        }

        public async Task<List<CustomersDTO>> SearchByName(string name)
        {
            var allCustomers = await _customersRepository.SearchByName(name);

            return _mapper.Map<List<CustomersDTO>>(allCustomers);
        }

        
    }
}
