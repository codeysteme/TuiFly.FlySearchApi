using Microsoft.Extensions.DependencyInjection;
using TuiFly.FlySearchApi.Domain.Interfaces;
using TuiFly.FlySearchApi.Infrastructure.Repository;

namespace TuiFly.FlySearchApi.Api.Extensions
{
    /// <summary>
    /// Configrure and Inject all D.I of app
    /// </summary>
    public static class ConfigureServices
    {
        public static IServiceCollection AddAppServices(this IServiceCollection service)
        {
            //DOMAIN
            service.Scan(scan =>
                scan.FromAssemblyOf<IAirportsManagerService>()
                .AddClasses(classes => classes.Where(type => type.Name.EndsWith("Service")))
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

            //INFRASTRUCTURE
            service.Scan(scan =>
                scan.FromAssemblyOf<AirportsRepositoryService>()
                .AddClasses(classes => classes.Where(type => type.Name.EndsWith("Service")))
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

            return service;
        }
    }
}
