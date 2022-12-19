using U_Send_First.Api.Middlewares;

namespace U_Send_First.Api.Extensions
{
    public static class IApplicationBuilderExtensions
    {
        public static void UseClaims(this IApplicationBuilder app)
        {
            app.UseMiddleware<ClaimSetupMiddleWare>();
        }
    }
}
