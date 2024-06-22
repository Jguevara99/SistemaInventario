using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Infrastructure.Persistences.Contexts;

namespace POS.Infrastructure.Extensions;

public static class InjectionExtensions
{
    public static IServiceCollection AddInjectionInfraestructure(this IServiceCollection services, IConfiguration configuration)
    {
        var assembly = typeof(SISVENTASContext).Assembly.FullName;

        services.AddDbContext<SISVENTASContext>(
            options => options.UseSqlServer(
                configuration.GetConnectionString("POSTConnection"), b => b.MigrationsAssembly(assembly)
                ),
            ServiceLifetime.Transient
            );

        return services;

    }
}
