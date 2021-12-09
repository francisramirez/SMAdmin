
using System.Collections.Generic;
using UseCases.Models;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewProductsUseCase
    {
        List<ProductListModel> Execute();
    }
}
