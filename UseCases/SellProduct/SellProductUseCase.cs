using CoreBusiness.Entities;
using Microsoft.Extensions.Logging;
using System;
using UseCases.Contracts;
using UseCases.Core;
using UseCases.Models;
using UseCases.UseCaseInterfaces;

namespace UseCases.SellProduct
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<SellProductUseCase> _logger;

        public SellProductUseCase(IProductRepository productRepository, 
                                  ILogger<SellProductUseCase> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }
        public UseCaseResult Execute(SellProductModel sellProduct)
        {
            UseCaseResult caseResult = new UseCaseResult();

            try
            {
                Product product = _productRepository.GetById(sellProduct.ProductId);

                if (product is null)
                {
                    caseResult.Message = "Product not found.";
                    caseResult.Success = false;
                    return caseResult;
                }

                product.Quantity -= sellProduct.QtyToSell;
                _productRepository.Update(product);

            }
            catch (Exception ex)
            {
                caseResult.Success = false;
                caseResult.Message = "Error procesing the sell.";
                _logger.LogError(caseResult.Message, ex);
            }
            return caseResult;
        }
    }
}
