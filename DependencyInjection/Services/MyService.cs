namespace DependencyInjection.Services
{
    public class MyService :IMyService
    {
        public string GetMessage()
        {
            return "Hello from Myservice using Dependency Injection";
        }
    }
}