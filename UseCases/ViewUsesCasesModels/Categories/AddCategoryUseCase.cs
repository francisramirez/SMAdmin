using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;
namespace UseCases.ViewUsesCasesModels.Categories
{
    public class AddCategoryUseCase : IAddCategoriesUseCase
    {
        private ICategoryRepository _categoryRepository;
        public AddCategoryUseCase(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

        public void Execute(Category entity) => _categoryRepository.AddCategory(entity);

    }
}
