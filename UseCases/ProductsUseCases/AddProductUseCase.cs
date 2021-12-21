using System;
using CoreBusiness.Entities;
using Microsoft.Extensions.Logging;
using UseCases.Contracts;
using UseCases.Core;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductsUseCases
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<AddProductUseCase> _logger;

        public AddProductUseCase(IProductRepository productRepository, 
                                 ILogger<AddProductUseCase> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }
        public UseCaseResult Execute(Product entity)
        {
            UseCaseResult caseResult = new UseCaseResult();

            try
            {
                _productRepository.Add(entity);
            }
            catch (Exception ex)
            {
                caseResult.Success = false;
                caseResult.Message = "Error adding product..";
                _logger.LogError(caseResult.Message, ex);
            }

            return caseResult;
        }
    }
}
