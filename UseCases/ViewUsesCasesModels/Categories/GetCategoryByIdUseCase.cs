
using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;

namespace UseCases.ViewUsesCasesModels.Categories
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoryByIdUseCase(ICategoryRepository categoryRepository) => this.categoryRepository = categoryRepository;
        public Category Execute(int categoryId)
        {
            return categoryRepository.GetById(categoryId);
        }
    }
}
