using csharp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace csharp
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<ConsoleService>();
        }
    }
}
