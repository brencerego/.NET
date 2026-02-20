namespace MVC
{
    public class RequestLoggingMiddleWare
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("___ INCOMMING MESSAGE___");
            Console.WriteLine($"Time    :  {DateTime.Now}");
            Console.WriteLine($"Method  : {context.Request.Method}");
            Console.WriteLine($"path    : {context.Request.Path}");
            Console.WriteLine("------------------------------------");

            await _next(context);
        }
    }
}
