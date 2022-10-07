using System.Globalization;
using System.Diagnostics;

namespace w3_asp.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseLogginMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogginMiddleware>();
        }
    }

}