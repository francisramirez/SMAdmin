using CoreBusiness.Entities;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewProductsByCategoryIdUseCase
    {
        public List<Product> Execute(int categoryId);
    }
}
