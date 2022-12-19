using U_Send_First.Common;
using System.Security.Claims;

namespace U_Send_First.Api.Middlewares
{
    internal class ClaimSetupMiddleWare
    {
        private readonly RequestDelegate next;

        public ClaimSetupMiddleWare(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, IClaims claims)
        {
            if (httpContext.User.Identity.IsAuthenticated)
            {
                claims.IsAuthenticated = true;
                claims.CurrentUser.Id = Guid.Parse(httpContext.User.Claims.First(f => f.Type == ClaimTypes.NameIdentifier).Value);
            }
            await next(httpContext);
        }
    }
}