
using CoreBusiness.Entities;
using UseCases.Core;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetProductByIdUseCase
    {
        public Product Execute(int productId);
    }
}
