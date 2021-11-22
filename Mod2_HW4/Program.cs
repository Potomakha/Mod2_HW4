using Microsoft.Extensions.DependencyInjection;
using Mod2_HW4.Interfaces;
using Mod2_HW4.Services;

namespace Mod2_HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IAnimalContainer, AnimalParkService>()
                .AddTransient<IAnimalTypesCalculator, AnimalTypesCulculator>()
                .AddTransient<Starter>()
                .BuildServiceProvider();
            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}
