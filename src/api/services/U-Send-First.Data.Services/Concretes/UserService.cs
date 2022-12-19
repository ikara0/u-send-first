using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using U_Send_First.Common;
using U_Send_First.Common.Extensions;
using U_Send_First.Data.Context;
using U_Send_First.Data.Dto;
using U_Send_First.Data.Services.Abstractions;
using U_Send_First.Entities.Profile;

namespace U_Send_First.Data.Services.Concretes
{
    internal class UserService : IUserService
    {
        private readonly USendFirstDbContext dbContext;
        private readonly Settings.JwtConfiguration configuration;

        public UserService(USendFirstDbContext dbContext, IOptions<Settings> options)
        {
            this.dbContext = dbContext;
            configuration = options.Value.Jwt;

        }

        public UserResultDto SignIn(SignInUserDto dto, CancellationToken cancellationToken)
        {
            var entity = dbContext.Users.SingleOrDefault(x => x.EMail == dto.EMail);
            if (entity is null)
            {
                return null;
            }
            var password = (entity.Hash + dto.Password).ComputeHash();
            if (entity.Password != password)
            {
                return null;
            }

            var claims = new Dictionary<string, object>
            {
                { ClaimTypes.NameIdentifier, entity.Id },
                { ClaimTypes.GivenName, entity.UserName }
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.Now.AddMinutes(configuration.ExpiresInMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.Key)), SecurityAlgorithms.HmacSha256Signature),
                Claims = claims,
                IssuedAt = DateTime.Now,
                NotBefore = DateTime.Now

            };

            var handler = new JwtSecurityTokenHandler();
            var token = handler.CreateToken(tokenDescriptor);
            var jwtToken = handler.WriteToken(token);
            return new UserResultDto
            {
                Token = jwtToken,
                UserName = entity.UserName
            };
       
        }

        public bool Register(RegisterDto dto)
        {
            var guid = Guid.NewGuid();

            var guidString = Convert.ToBase64String(guid.ToByteArray());
            guidString = guidString.Replace("=", "");
            guidString = guidString.Replace("+", "");

            var hashedPassword = (guidString + dto.Password).ComputeHash();

            var user = new User()
            {
                UserName = dto.UserName,
                Password = hashedPassword,
                Hash = guidString,
                CreatedAt = DateTime.Now,
                EMail = dto.Email
            };

            dbContext.Add(user);
            return dbContext.SaveChanges() > 0;
        }
    }
}