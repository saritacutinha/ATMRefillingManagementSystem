
using ATMRefillingManagementSystem.Data;
using ATMRefillingManagementSystem.Persistence;
using Microsoft.Extensions.DependencyInjection;
using ATMRefillingManagementSystem.Core;
using System.Threading.Tasks;

namespace ATMRefillingManagementSystem
{
    class Program
    {
        
        static async Task Main(string[] args)
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<ATMRefillingManagementMenu>().DisplayMenu();
           
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddDbContext<ATMRefillingManagementSystemDbContext>();
            services.AddTransient<IBankRepository, BankRepository>();
            services.AddTransient<IBankRepository, BankRepository>();
            services.AddTransient<IRefillRepository, RefillRepository>();
            services.AddTransient<ATMRefillingManagementMenu>();
            return services;
        }
    }
}
