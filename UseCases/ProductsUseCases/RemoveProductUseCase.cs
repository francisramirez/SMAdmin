using Microsoft.Extensions.Logging;
using System;
using UseCases.Contracts;
using UseCases.Core;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductsUseCases
{
    public class RemoveProductUseCase : IRemoveProductUseCase
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<RemoveProductUseCase> _logger;

        public RemoveProductUseCase(IProductRepository productRepository, 
                                    ILogger<RemoveProductUseCase> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }
        
        public UseCaseResult RemoveProduct(int productId)
        {
            UseCaseResult caseResult = new UseCaseResult();

            try
            {
                _productRepository.Remove(productId);
            }
            catch (Exception ex)
            {
                caseResult.Message = "Error removing products";
                caseResult.Success = false;
                _logger.LogInformation(caseResult.Message, ex);

            }

            return caseResult;
        }
    }
}
