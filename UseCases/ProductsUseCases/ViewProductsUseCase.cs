using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using UseCases.Contracts;
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
        public List<ProductListModel> Execute()
        {
            List<ProductListModel> products = new List<ProductListModel>();

            try
            {
                products = (from pro in _productRepository.GetAll()
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


            }
            catch (Exception ex)
            {
                _logger.LogError("Error getting the products", ex);
            }

            return products;
        }
    }
}
