
using UseCases.Core;
using UseCases.Models;

namespace UseCases.UseCaseInterfaces
{
    public interface ISellProductUseCase
    {
        public UseCaseResult Execute(SellProductModel sellProduct);
    }
}
