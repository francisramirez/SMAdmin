using CoreBusiness.Entities;
using System.Collections.Generic;
using UseCases.Contracts;

namespace DataInMemory.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> Entities { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Add(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int entityId)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
