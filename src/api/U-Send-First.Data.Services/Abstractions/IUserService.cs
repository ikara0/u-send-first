using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U_Send_First.Data.Dto;

namespace U_Send_First.Data.Services.Abstractions
{
    public interface IUserService
    {
        UserResultDto SignIn(SignInUserDto dto);
    }
}
