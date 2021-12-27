using CoreBusiness.Entities;
using System.Collections.Generic;
using UseCases.Core;

namespace UseCases.Contracts
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        public IEnumerable<Product> GetProductByCategoryId(int categoryId);
    }
}
