using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Middleware
{
    public class RequestLoggingMiddleware : Controller
    {
            private readonly RequestDelegate _next;
            public RequestLoggingMiddleware(RequestDelegate next)
            {
                _next = next;
            }

            public async Task Invoke(HttpContext context)
            {
                Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");
                await _next(context);
                Console.WriteLine($"[Response] {context.Response.StatusCode}");
            } 
    }
}
