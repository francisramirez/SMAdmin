
using DataInMemory.Repositories;
using Microsoft.Extensions.DependencyInjection;
using UseCases.Contracts;
using UseCases.RecordTransation;
using UseCases.UseCaseInterfaces;

namespace SMWebApp.Dependency
{
    public static class TransactionDependency
    {
        public static IServiceCollection AddTransactionDependency(this IServiceCollection services)
        {
            //Repositories
            services.AddScoped<ITransactionRepository, TransactionRepository>();


            //Use Cases//
            services.AddTransient<IRecordTransationUseCase, RecordTransationUseCase>();

            return services;
        }
    }
}
