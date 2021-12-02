using CoreBusiness.Entities;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetCategoryByIdUseCase
    {
        public Category Execute(int categoryId);
    }
}
