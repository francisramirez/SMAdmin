using System.Collections.Generic;
using System.Linq;
using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.UseCaseInterfaces;

namespace UseCases.ViewUsesCasesModels.Categories
{
    public class ViewCategoriesUseCases : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository _categoryRepository;
        public ViewCategoriesUseCases(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

        public List<Category> GetCategories() => _categoryRepository.GetCategories().ToList();
    }
}
