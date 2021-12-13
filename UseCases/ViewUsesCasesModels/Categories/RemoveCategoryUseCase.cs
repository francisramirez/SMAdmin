using CoreBusiness.Entities;
using System;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;

namespace UseCases.ViewUsesCasesModels.Categories
{
    public class RemoveCategoryUseCase : IRemoveCategoryUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public RemoveCategoryUseCase(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

        public void RemoveCategory(int categoryId) => _categoryRepository.Remove(categoryId);
    }
}
