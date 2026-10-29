
using App.HanJho.Cloud.UseCases.CreateProduct;
using App.HanJho.Cloud.UseCases.GetAllProducts;
using App.HanJho.Cloud.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace App.HanJho.Cloud.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
    { 
        services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
        services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>(); 
        return services;
    }
}
