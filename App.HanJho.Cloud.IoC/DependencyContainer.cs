using App.HanJho.Cloud.Presenters;
using App.HanJho.Cloud.RepositoryEFCore;
using App.HanJho.Cloud.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.HanJho.Cloud.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDependencyContainer(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCasesServices();
            services.AddPresenter();
            return services;
        }
    }
}
