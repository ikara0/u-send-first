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
        //public UserResultDto SignIn(SignInUserDto dto)
        //{
        //    var entity = dbContext.Users.SingleOrDefault(x => x.EMail == dto.EMail);
        //    if(entity == null)
        //    {
        //        return null;
        //    }


        //}
        //TODO : apply ComputeHash algorithm !!
    }
}