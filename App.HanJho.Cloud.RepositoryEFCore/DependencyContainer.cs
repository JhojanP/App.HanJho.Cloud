using App.HanJho.Cloud.Entities.Interfaces;
using App.HanJho.Cloud.RepositoryEFCore.DataContext;
using App.HanJho.Cloud.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.HanJho.Cloud.RepositoryEFCore; 
public static class DependencyContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<EFCoreContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }   
}
