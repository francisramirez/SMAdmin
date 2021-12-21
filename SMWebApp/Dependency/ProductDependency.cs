using Microsoft.Extensions.DependencyInjection;
using UseCases.Contracts;
using UseCases.ProductsUseCases;
using UseCases.UseCaseInterfaces;
using DataInMemory.Repositories;

namespace SMWebApp.Dependency
{
    public static class ProductDependency
    {
        public static IServiceCollection AddProductDependency(this IServiceCollection services)
        {

            //Repositories//
            services.AddScoped<IProductRepository, ProductRepository>();


            //Use Cases//
            services.AddTransient<IViewProductsUseCase, ViewProductsUseCase>();
            services.AddTransient<IAddProductUseCase, AddProductUseCase>();
            services.AddTransient<IGetProductByIdUseCase, GetProductByIdUseCase>();
            services.AddTransient<IEditProductUseCase, EditProductUseCase>();
            services.AddTransient<IRemoveProductUseCase, RemoveProductUseCase>();
            return services;
        }
    }
}
