namespace Mocks
{
    using Newtonsoft.Json;
    public static class WebServer
    {
        public static void Run() 
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();
        }
    }
}
