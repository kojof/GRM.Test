using System;
using GRM.Application.Services;
using GRM.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GRM.ConsoleApp
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {

            RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            scope.ServiceProvider.GetRequiredService<ConsoleApplication>().Run();
            DisposeServices();
        }


        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IProductService, ProductService>();
            services.AddSingleton<ConsoleApplication>();
            _serviceProvider = services.BuildServiceProvider(true);
        }




        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
