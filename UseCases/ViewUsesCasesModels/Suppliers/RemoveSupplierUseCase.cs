using Microsoft.Extensions.Logging;
using System;
using UseCases.Contracts;
using UseCases.Core;
using UseCases.UseCaseInterfaces;

namespace UseCases.ViewUsesCasesModels.Suppliers
{
    public class RemoveSupplierUseCase : IRemoveSupplierUseCase
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly ILogger<RemoveSupplierUseCase> _logger;

        public RemoveSupplierUseCase(ISupplierRepository supplierRepository, 
                                     ILogger<RemoveSupplierUseCase> logger)
        {
            _supplierRepository = supplierRepository;
            _logger = logger;
        }
        public UseCaseResult RemoveSupplier(int supplierId)
        {
            UseCaseResult caseResult = new UseCaseResult();

            try
            {
                _supplierRepository.Remove(supplierId);
                caseResult.Success = true;
            }
            catch (Exception ex)
            {
                caseResult.Success = false;
                caseResult.Message = "Error removing supplier";
                _logger.LogError(caseResult.Message,ex);
            }

            return caseResult;
        }
    }
}
