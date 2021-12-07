using UseCases.Core;

namespace UseCases.UseCaseInterfaces
{
    public interface IRemoveSupplierUseCase
    {
        public UseCaseResult RemoveSupplier(int supplierId);
    }
}
