using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;
namespace UseCases.ViewUsesCasesModels.Categories
{
    public class AddCategoriesUseCase : IAddCategoriesUseCase
    {
        private ICategoryRepository _categoryRepository;
        public AddCategoriesUseCase(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

        public void AddCategory(Category category) => _categoryRepository.AddCategory(category);
    }
}
