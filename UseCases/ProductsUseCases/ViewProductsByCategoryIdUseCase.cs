using CoreBusiness.Entities;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;
using System.Linq;
namespace UseCases.ProductsUseCases
{
    public class ViewProductsByCategoryIdUseCase : IViewProductsByCategoryIdUseCase
    {
        private readonly IProductRepository _productRepository;
        public ViewProductsByCategoryIdUseCase(IProductRepository productRepository) => _productRepository = productRepository;
        public List<Product> Execute(int categoryId) => _productRepository.GetProductByCategoryId(categoryId).ToList();
    }
}
