using System;
using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;

namespace UseCases.ViewUsesCasesModels.Categories
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public EditCategoryUseCase(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

        public void Execute(Category category)
        {
            _categoryRepository.UpdateCategory(category);
        }
    }
}
