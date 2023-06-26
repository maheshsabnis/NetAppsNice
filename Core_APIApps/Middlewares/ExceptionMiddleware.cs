using Core_APIApps.Models;

namespace Core_APIApps.Middlewares
{
    // Like class but optimized for memory management in C# 9.0+
    public record ErrorInformation
    {
        public int StatuCode { get; set; }
        public string? ErrorMessage { get; set; }
    }

    public class ExceptionMiddleware
    {
        private RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
                _next = next;
        }
        /// <summary>
        /// Logic for Custom Middleware
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context) 
        {
            try
            {
                // If no error then continue execution with the next middleware
                // in Pipeline
                await _next(context);
            }
            catch (Exception ex)
            {
                /*Handle exception and return response*/
                ErrorInformation errorInformation = new ErrorInformation();
                // 1. set the status code
                context.Response.StatusCode = 500;
                // 2. set data to the error object
                errorInformation.StatuCode = context.Response.StatusCode;
                errorInformation.ErrorMessage = ex.Message;
                // 3. generate response
                await context.Response.WriteAsJsonAsync(errorInformation);
            }
        }
    }


    /// <summary>
    /// An Extension class that will be used to register the ExceptionMiddleware class as 
    /// custom middleware
    /// </summary>
    public static class ExceptionMiddlewareExtension
    {
        public static void UseExceptionMiddleware(this IApplicationBuilder builder)
        { 
            builder.UseMiddleware<ExceptionMiddleware>();
        }
    }

}
