using UseCases.Core;

namespace UseCases.UseCaseInterfaces
{
    public interface IRemoveProductUseCase 
    {
        public UseCaseResult RemoveProduct(int productId);
    }
}
