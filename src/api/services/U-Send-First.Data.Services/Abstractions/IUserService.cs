using U_Send_First.Data.Dto;

namespace U_Send_First.Data.Services.Abstractions
{
    public interface IUserService
    {
        UserResultDto SignIn(SignInUserDto dto, CancellationToken cancellationToken);
        bool Register(RegisterDto dto);
    }
}