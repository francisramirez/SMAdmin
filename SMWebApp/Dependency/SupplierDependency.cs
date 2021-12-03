using DataInMemory.Repositories;
using Microsoft.Extensions.DependencyInjection;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;
using UseCases.ViewUsesCasesModels.Suppliers;

namespace SMWebApp.Dependency
{
    public static class SupplierDependency
    {
        public static IServiceCollection AddCategoryDependency(this IServiceCollection services)
        {

            //Repositories//
            services.AddScoped<ISupplierRepository, SupplierRepository>();

            //Use Cases//
            services.AddTransient<IViewSuppliersUseCase, ViewSuppliersUseCase>();
            services.AddTransient<IAddSupplierUseCase, AddSupplierUseCase>();
           

            return services;
        }
    }
}
