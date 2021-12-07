using System;
using Microsoft.Extensions.Logging;
using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.Core;
using UseCases.Exceptions;
using UseCases.UseCaseInterfaces;

namespace UseCases.ViewUsesCasesModels.Suppliers
{
    public class EditSupplierUseCase : IEditSupplierUseCase
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly ILogger<EditSupplierUseCase> _logger;

        public EditSupplierUseCase(ISupplierRepository supplierRepository, 
                                   ILogger<EditSupplierUseCase> logger)
        {
            _supplierRepository = supplierRepository;
            _logger = logger;
        }
        public UseCaseResult Execute(Supplier entity)
        {
            UseCaseResult useCase = new UseCaseResult();

            try
            {
                _supplierRepository.Update(entity);
            }
            catch(SupplierException sex) 
            {
                useCase.Message = sex.Message;
                useCase.Success = false;
                _logger.LogError($"Error updating a supplier {sex.Message}", sex);
            }
            catch (Exception ex)
            {
                useCase.Message = ex.Message;
                useCase.Success = false;
                _logger.LogError($"Internal error updating a supplier {ex.Message}", ex);
            }
            return useCase;
        }
    }
}
