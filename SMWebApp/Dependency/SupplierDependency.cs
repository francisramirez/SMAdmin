using DataInMemory.Repositories;
using Microsoft.Extensions.DependencyInjection;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;
using UseCases.ViewUsesCasesModels.Suppliers;

namespace SMWebApp.Dependency
{
    public static class SupplierDependency
    {
        public static IServiceCollection AddSupplierDependency(this IServiceCollection services)
        {

            //Repositories//
            services.AddScoped<ISupplierRepository, SupplierRepository>();

            //Use Cases//
            services.AddTransient<IViewSuppliersUseCase, ViewSuppliersUseCase>();
            services.AddTransient<IAddSupplierUseCase, AddSupplierUseCase>();
            services.AddTransient<IGetSupplierByIdUseCase, GetSupplierByIdUseCase>();
            services.AddTransient<IEditSupplierUseCase, EditSupplierUseCase>();
            services.AddTransient<IRemoveSupplierUseCase, RemoveSupplierUseCase>();

            return services;
        }
    }
}
