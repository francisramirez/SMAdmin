using Microsoft.Extensions.DependencyInjection;
using UseCases.SellProduct;
using UseCases.UseCaseInterfaces;

namespace SMWebApp.Dependency
{
    public static class SellProductDependency
    {
        public static IServiceCollection AddSellProductDependency(this IServiceCollection services)
        {
            //Use Cases Sell Product Modules//
            services.AddTransient<ISellProductUseCase, SellProductUseCase>();

            return services;

        }
    }
}
