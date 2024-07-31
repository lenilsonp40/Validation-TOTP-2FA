using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Validacao_TOTP_2FA.API.Utilities;
using Validacao_TOTP_2FA.API.ViewModels;
using Validacao_TOTP_2FA.Core.Exceptions;
using Validacao_TOTP_2FA.Services.DTO;
using Validacao_TOTP_2FA.Services.Interfaces;

namespace Validacao_TOTP_2FA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly ICustomersService _customersService;

        public CustomersController(IMapper mapper, ICustomersService customersService)
        {
            _mapper = mapper;
            _customersService = customersService;
        }



        [HttpGet]
       // [Authorize]
        [Route("/api/v1/users/get-all")]
        public async Task<IActionResult> GetAsync()
        {
            var customersUsers = await _customersService.GetAllAsync();
            

            return Ok(new ResultViewModel
            {
                Message = "Usuários encontrados com sucesso!",
                Success = true,
                Data = customersUsers
            });
        }


        [HttpPost]
        [Route("/api/v1/customers/create")]
        public async Task<IActionResult> Create([FromBody] CreateCustomersViewModel customersViewModel)
        {
            try
            {
                var customersDTO = _mapper.Map<CustomersDTO>(customersViewModel);

                var customersCreated = await _customersService.Create(customersDTO);

                return Ok(new ResultViewModel
                {
                    Message = "Usuário criado com sucesso!",
                    Success = true,
                    Data = customersCreated
                });


            }
            catch (DomainException ex)
            {
                 return BadRequest(Responses.DomainErrorMessage(ex.Message, ex.Errors));
               
            }
            catch (Exception)
            {
                
                 return StatusCode(500, Responses.ApplicationErrorMessage());
                

            }

        }




        //[HttpPut]
        //[Authorize]
        //[Route("/api/v1/users/update")]
        //public async Task<IActionResult> UpdateAsync([FromBody] UpdateUserViewModel userViewModel)
        //{
        //    var userDTO = _mapper.Map<UserDTO>(userViewModel);
        //    var userUpdated = await _userService.UpdateAsync(userDTO);

        //    if (HasNotifications())
        //        return Result();

        //    return Ok(new ResultViewModel
        //    {
        //        Message = "Usuário atualizado com sucesso!",
        //        Success = true,
        //        Data = userUpdated.Value
        //    });
        //}

        //[HttpDelete]
        //[Authorize]
        //[Route("/api/v1/users/remove/{id}")]
        //public async Task<IActionResult> RemoveAsync(long id)
        //{
        //    await _userService.RemoveAsync(id);

        //    if (HasNotifications())
        //        return Result();

        //    return Ok(new ResultViewModel
        //    {
        //        Message = "Usuário removido com sucesso!",
        //        Success = true,
        //        Data = null
        //    });
        //}

        //[HttpGet]
        //[Authorize]
        //[Route("/api/v1/users/get/{id}")]
        //public async Task<IActionResult> GetAsync(long id)
        //{
        //    var user = await _userService.GetAsync(id);

        //    if (HasNotifications())
        //        return Result();

        //    if (!user.HasValue)
        //        return Ok(new ResultViewModel
        //        {
        //            Message = "Nenhum usuário foi encontrado com o ID informado.",
        //            Success = true,
        //            Data = user.Value
        //        });

        //    return Ok(new ResultViewModel
        //    {
        //        Message = "Usuário encontrado com sucesso!",
        //        Success = true,
        //        Data = user.Value
        //    });
        //}




        //[HttpGet]
        //[Authorize]
        //[Route("/api/v1/users/get-by-email")]
        //public async Task<IActionResult> GetByEmailAsync([FromQuery] string email)
        //{
        //    var user = await _userService.GetByEmailAsync(email);

        //    if (HasNotifications())
        //        return Result();

        //    if (!user.HasValue)
        //        return Ok(new ResultViewModel
        //        {
        //            Message = "Nenhum usuário foi encontrado com o email informado.",
        //            Success = true,
        //            Data = user.Value
        //        });

        //    return Ok(new ResultViewModel
        //    {
        //        Message = "Usuário encontrado com sucesso!",
        //        Success = true,
        //        Data = user.Value
        //    });
        //}

        //[HttpGet]
        //[Authorize]
        //[Route("/api/v1/users/search-by-name")]
        //public async Task<IActionResult> SearchByNameAsync([FromQuery] string name)
        //{
        //    var allUsers = await _userService.SearchByNameAsync(name);

        //    if (HasNotifications())
        //        return Result();

        //    if (!allUsers.HasValue)
        //        return Ok(new ResultViewModel
        //        {
        //            Message = "Nenhum usuário foi encontrado com o nome informado",
        //            Success = true,
        //            Data = null
        //        });

        //    return Ok(new ResultViewModel
        //    {
        //        Message = "Usuário encontrado com sucesso!",
        //        Success = true,
        //        Data = allUsers
        //    });
        //}


        //[HttpGet]
        //[Authorize]
        //[Route("/api/v1/users/search-by-email")]
        //public async Task<IActionResult> SearchByEmailAsync([FromQuery] string email)
        //{
        //    var allUsers = await _userService.SearchByEmailAsync(email);

        //    if (HasNotifications())
        //        return Result();

        //    if (!allUsers.HasValue)
        //        return Ok(new ResultViewModel
        //        {
        //            Message = "Nenhum usuário foi encontrado com o email informado",
        //            Success = true,
        //            Data = null
        //        });

        //    return Ok(new ResultViewModel
        //    {
        //        Message = "Usuário encontrado com sucesso!",
        //        Success = true,
        //        Data = allUsers
        //    });
        //}



    }
}
