using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using U_Send_First.Data.Dto;
using U_Send_First.Data.Services.Abstractions;

namespace U_Send_First.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }
        [HttpPost("login")]
        public IActionResult SignIn([FromBody] SignInUserDto dto)
        {
            var result = service.SignIn(dto);
            if(result is  null){
                return BadRequest("Login Failed!");
            }
            return Ok(result);
        }
    }
}
