using csharp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            var consoleService = serviceProvider.GetRequiredService<ConsoleService>();
            consoleService.Run();
        } 
    }
}
