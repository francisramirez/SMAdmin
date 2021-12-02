using DataInMemory.Repositories;
using Microsoft.Extensions.DependencyInjection;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;
using UseCases.ViewUsesCasesModels.Categories;

namespace SMWebApp.Dependency
{
    public static class CategoryDependency
    {
        public static IServiceCollection AddCategoryDependency(this IServiceCollection services) 
        {

            //Repositories//
            services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();

            //Use Cases//
            services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCases>();
            services.AddTransient<IAddCategoriesUseCase, AddCategoryUseCase>();
            services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
            services.AddTransient<IRemoveCategoryUseCase, RemoveCategoryUseCase>();
            services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
            
            return services;
        }
    }
}
