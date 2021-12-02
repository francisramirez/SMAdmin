using CoreBusiness.Entities;

namespace UseCases.UseCaseInterfaces
{
    public interface IRemoveCategoryUseCase 
    {
        public void RemoveCategory(int categoryId);
    }
}