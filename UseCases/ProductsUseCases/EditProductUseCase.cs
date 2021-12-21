using CoreBusiness.Entities;
using Microsoft.Extensions.Logging;
using System;
using UseCases.Contracts;
using UseCases.Core;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductsUseCases
{
    public class EditProductUseCase : IEditProductUseCase
    {
        private readonly ILogger<EditProductUseCase> _logger;
        private readonly IProductRepository _productRepository;

        public EditProductUseCase(ILogger<EditProductUseCase> logger, 
                                  IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }
        public UseCaseResult Execute(Product entity)
        {
            UseCaseResult caseResult = new UseCaseResult();

            try
            {
                _productRepository.Update(entity);
            }
            catch (Exception ex)
            {

                caseResult.Message = "Error updating product info.";
                caseResult.Success = false;
                _logger.LogInformation(caseResult.Message, ex);
            }

            return caseResult;
        }
    }
}
