using U_Send_First.Common.Extensions;
using U_Send_First.Data.Context;
using U_Send_First.Data.Dto;
using U_Send_First.Data.Services.Abstractions;

namespace U_Send_First.Data.Services.Concretes
{
    internal class UserService : IUserService
    {
        private readonly USendFirstDbContext dbContext;

        public UserService(USendFirstDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public UserResultDto SignIn(SignInUserDto dto)
        {
            var entity = dbContext.Users.SingleOrDefault(x => x.EMail == dto.EMail);
            if(entity is null)
            {
                return null;
            }
            var password = (entity.Hash + dto.Password).ComputeHash();
            if(entity.Password != password)
            {
                return null;
            }
            var loginUser = new UserResultDto
            {
                Id  = entity.Id,
                UserName = entity.UserName
            };
            return loginUser;
        }
    }
}