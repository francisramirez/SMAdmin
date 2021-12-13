using System;
using CoreBusiness.Entities;
using Microsoft.Extensions.Logging;
using UseCases.Contracts;
using UseCases.Core;
using UseCases.Exceptions;
using UseCases.UseCaseInterfaces;
namespace UseCases.ViewUsesCasesModels.Categories
{
    public class AddCategoryUseCase : IAddCategoriesUseCase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILogger<AddCategoryUseCase> _logger;

        public AddCategoryUseCase(ICategoryRepository categoryRepository, ILogger<AddCategoryUseCase> logger)
        {
            _categoryRepository = categoryRepository;
            _logger = logger;
        }

        public UseCaseResult Execute(Category entity)
        {
            UseCaseResult result = new UseCaseResult();

            try
            {
                _categoryRepository.Add(entity);
            }
            catch (CategoryException cex) 
            {
                result.Message = cex.Message;
                result.Success = false;
                _logger.LogError($"Error adding a category {cex.Message}", cex);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                _logger.LogError($"Internal error adding a category {ex.Message}", ex);
            }
            return result;
        }

       
    }
}
