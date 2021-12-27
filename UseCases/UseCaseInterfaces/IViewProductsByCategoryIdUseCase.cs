using CoreBusiness.Entities;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewProductsByCategoryIdUseCase
    {
        public List<Product> GetProductsByCategoryId(int categoryId);
    }
}
