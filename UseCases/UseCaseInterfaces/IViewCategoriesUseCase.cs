using CoreBusiness.Entities;
using System.Collections.Generic;
namespace UseCases.UseCaseInterfaces
{
    public interface IViewCategoriesUseCase
    {
        public List<Category> Execute();
    }
}
