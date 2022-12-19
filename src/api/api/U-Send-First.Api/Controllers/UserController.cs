using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using U_Send_First.Data.Dto;
using U_Send_First.Data.Services.Abstractions;

namespace U_Send_First.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public class UserController : ControllerBase
{
    private readonly IUserService service;

    public UserController(IUserService service)
    {
        this.service = service;
    }
    [HttpPost("login")]
    public IActionResult SignIn([FromBody] SignInUserDto dto, CancellationToken cancellationToken)
    {
        var result = service.SignIn(dto, cancellationToken);
        if(result is  null){
            return BadRequest("Login Failed!");
        }
        return Ok(result);
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterDto dto)
    {
        var result = service.Register(dto);
        if(result is false)
        {
            return BadRequest("Register Failed");
        }
        return Ok(result);

    }
  
}
