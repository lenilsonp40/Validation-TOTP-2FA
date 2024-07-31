using AutoMapper;
using Validacao_TOTP_2FA.API.ViewModels;
using Validacao_TOTP_2FA.Services.DTO;

namespace Validacao_TOTP_2FA.API.Utilities.DTOMappings
{
    public class UserDTOMappingProfile : Profile
    {
        public UserDTOMappingProfile()
        {
            CreateMap<CreateCustomersViewModel, CustomersDTO>().ReverseMap();

        }
    }
}
