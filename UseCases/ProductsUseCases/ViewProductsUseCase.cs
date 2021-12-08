using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using UseCases.Contracts;
using UseCases.Core;
using UseCases.Models;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductsUseCases
{
    public class ViewProductsUseCase : IViewProductsUseCase
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly ILogger<ViewProductsUseCase> _logger;

        public ViewProductsUseCase(IProductRepository productRepository,
                                   ICategoryRepository categoryRepository,
                                   ISupplierRepository supplierRepository,
                                   ILogger<ViewProductsUseCase> logger)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _supplierRepository = supplierRepository;
            _logger = logger;
        }
        public UseCaseResult Execute()
        {
            UseCaseResult caseResult = new();

            try
            {
                var products = (from pro in _productRepository.GetAll()
                                join ca in _categoryRepository.GetCategories() on pro.CategoryId equals ca.CategoryId
                                join su in _supplierRepository.GetAll() on pro.SupplierId equals su.SupplierId
                                select new ProductListModel()
                                {
                                    CategoryId = ca.CategoryId,
                                    CategoryName = ca.Name,
                                    Name = pro.Name,
                                    Discontinued = pro.Discontinued,
                                    ProductId = pro.ProductId,
                                    SupplierId = su.SupplierId,
                                    SupplierName = su.CompanyName,
                                    UnitPrice = pro.UnitPrice
                                }).ToList();


                caseResult.Success = false;
                caseResult.Data = products;

            }
            catch (Exception ex)
            {
                caseResult.Success = false;
                caseResult.Message = "Error getting the products";
                _logger.LogError(caseResult.Message, ex);
            }

            return caseResult;
        }
    }
}
