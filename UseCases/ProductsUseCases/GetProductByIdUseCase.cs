

using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductsUseCases
{
    public class GetProductByIdUseCase : IGetProductByIdUseCase
    {
        private readonly IProductRepository _repositoryProduct;

        public GetProductByIdUseCase(IProductRepository repositoryProduct) => _repositoryProduct = repositoryProduct;
        public Product Execute(int productId) => _repositoryProduct.GetById(productId);
    }
}
