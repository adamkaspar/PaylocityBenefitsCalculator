using System.Net;

namespace Api.Common.Infrastructure;

public class Error
{
    public Guid CorrelationId { get; set; }

    public HttpStatusCode StatusCode { get; set; }

    public string Message { get; set; } = string.Empty;
}