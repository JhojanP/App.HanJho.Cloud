using App.HanJho.Cloud.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection; 

namespace App.HanJho.Cloud.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddPresenter(this IServiceCollection services)
    {
        services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
        services.AddScoped<IGetAllProductsOutputPort, GetAllProductsPresenter>();
        return services;
    }
}
