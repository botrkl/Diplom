using OnlineStore.BLL.Exceptions;
using System.Net;

namespace OnlineStore.API.Extensions
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (InvalidPasswordException ex)
            {
                await HandleException(httpContext, ex, "An auth error occurred", (int)HttpStatusCode.Unauthorized);
            }
            catch (InvalidEmailAddressException ex)
            {
                await HandleException(httpContext, ex, "An auth error occurred", (int)HttpStatusCode.Unauthorized);
            }
            catch (UserAlreadyExistsException ex)
            {
                await HandleException(httpContext, ex, "An auth error occurred", (int)HttpStatusCode.Conflict);
            }
            catch (UserIsNotExistsException ex)
            {
                await HandleException(httpContext, ex, "An auth error occurred", (int)HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                await HandleException(httpContext, ex, "An error occurred", (int)HttpStatusCode.InternalServerError);
            }
        }

        private async Task HandleException(HttpContext httpContext, Exception exception, string logMessage, int statusCode)
        {
            var correlationId = Guid.NewGuid();
            _logger.LogError(logMessage + ". {ExceptionType}. {ExceptionMessage}. {CorrelationId}.",
                exception.GetType().FullName,
                exception.Message,
                correlationId);

            httpContext.Response.StatusCode = statusCode;
            await httpContext.Response.WriteAsync($"{exception.Message}. Correlation ID: {correlationId}.");
        }
    }
}