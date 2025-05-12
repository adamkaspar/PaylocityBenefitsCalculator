using Api.Common.Infrastructure;
using System.Net;

namespace Api.PresentationLayer.Middleware;

public class ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var correlationId = Guid.NewGuid();

        logger.LogError(exception, $"CorrelationId: {correlationId}. An unexpected error occurred.");

        var response = exception switch
        {
            ApplicationException _ => new ApiResponse<Error>
            {
                Data = new Error
                {
                    CorrelationId = correlationId,
                    StatusCode = HttpStatusCode.BadRequest,
                    Message = "Application exception occurred"
                },
                Error = "Application exception occurred.",
                Message = $"CorrelationId: {correlationId}, HttpStatusCode: {HttpStatusCode.BadRequest} Message: Application exception occurred.",
                Success = false
            },
            _ => new ApiResponse<Error>
            {
                Data = new Error
                {
                    CorrelationId = correlationId,
                    StatusCode = HttpStatusCode.InternalServerError,
                    Message = "Internal server error. Please retry later."
                },
                Message = $"CorrelationId: {correlationId}, HttpStatusCode: {HttpStatusCode.InternalServerError} Message: Internal server error. Please retry later.",
                Success = false
            }
        };

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)response.Data.StatusCode;

        await context.Response.WriteAsJsonAsync(response);
    }
}