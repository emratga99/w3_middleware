using System.Globalization;
using System.Diagnostics;

namespace w3_asp.Middlewares;

public class LogginMiddleware
{
    private readonly RequestDelegate _next;

    public LogginMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var request = context.Request;

        string info = "\r\t Scheme: " + request.Scheme +
        "\r\t Host: " + request.Host +
        "\r\t Path: " + request.Path +
        "\r\t QueryString: " + request.QueryString +
        "\r\t RequestBody: " + request.Body;

        Debug.Write(info);
        File.WriteAllText("textInfomation.txt", info);

        await _next(context);
    }
}