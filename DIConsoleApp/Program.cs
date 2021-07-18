using System;
using System.Threading.Tasks;
using DIConsoleApp.Implementations;
using DIConsoleApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DIConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create a new instance of ServiceCollection.
            var serviceCollection = new ServiceCollection();

            // Configure the required services into the serviceCollection.
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            try
            {
                // Run the initial service.
                await serviceProvider.GetService<IProcessor>().Waiter();

                Console.WriteLine("Task Accomplished successfully!");
            }
            catch (Exception ex)
            {
                // Log the exception to console.
                Console.WriteLine($"Error occurred: {ex.Message}");
            }

            Console.ReadKey();
        }

        private static void ConfigureServices(ServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IProcessor, Processor>();
        }
    }
}
