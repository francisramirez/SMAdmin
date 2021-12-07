using System;
using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.Core;
using UseCases.UseCaseInterfaces;

namespace UseCases.ViewUsesCasesModels.Categories
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public EditCategoryUseCase(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

        public UseCaseResult Execute(Category category)
        {
            UseCaseResult result = new UseCaseResult();

            _categoryRepository.UpdateCategory(category);

            return result;
        }
    }
}
