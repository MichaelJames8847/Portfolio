using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace PortfolioProject.Data
{
    public class TokenAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _authToken;

        public TokenAuthenticationMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _authToken = configuration["AuthToken"]; // Retrieve the auth token from configuration
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Check if the request is for a protected path
            if (context.Request.Path.StartsWithSegments("/api/blog/create") ||
                context.Request.Path.StartsWithSegments("/api/project/add"))
            {
                // Check for the correct authorization header
                if (context.Request.Headers["Authorization"] != $"Bearer {_authToken}")
                {
                    context.Response.StatusCode = 401; // Unauthorized
                    return; // Short-circuit the request
                }
            }

            await _next(context); // Call the next delegate/middleware in the pipeline
        }
    }
}
