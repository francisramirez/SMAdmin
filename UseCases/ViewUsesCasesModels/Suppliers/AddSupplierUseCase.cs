using System;
using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;
using UseCases.Exceptions;
using UseCases.Core;
using Microsoft.Extensions.Logging;

namespace UseCases.ViewUsesCasesModels.Suppliers
{
    public class AddSupplierUseCase : IAddSupplierUseCase
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly ILogger<AddSupplierUseCase> _logger;

        public AddSupplierUseCase(ISupplierRepository supplierRepository, ILogger<AddSupplierUseCase> logger)
        {
            _supplierRepository = supplierRepository;
            _logger = logger;
        }

        public UseCaseResult Execute(Supplier entity)
        {
            UseCaseResult useCase = new UseCaseResult();

            try
            {
                _supplierRepository.Add(entity);

            }
            catch (SupplierException sex)
            {
                useCase.Message = sex.Message;
                useCase.Success = false;
                _logger.LogError($"Error adding a supplier {sex.Message}", sex);
            }
            catch (Exception ex)
            {
                useCase.Message = ex.Message;
                useCase.Success = false;
                _logger.LogError($"Internal error adding a supplier {ex.Message}", ex);
            }

            return useCase;
        }
    }
}
