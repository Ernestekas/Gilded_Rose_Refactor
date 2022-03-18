using csharp.Models;
using csharp.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

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
