using CoreBusiness.Entities;
using System.Collections.Generic;
using UseCases.Contracts;
using System.Linq;
using System;
using UseCases.Exceptions;

namespace DataInMemory.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> Entities { get; set; }
        public ProductRepository()
        {
            this.Entities = new List<Product>()
            {
                 new Product()
                 {
                     ProductId= 1,
                     CategoryId=1,
                     Discontinued=false,
                     Name="Product HHYDP",
                     SupplierId= 1,
                     UnitPrice = 18,
                 },
                 new Product()
                 {
                     ProductId= 2,
                     CategoryId= 1,
                     Discontinued=true,
                     Name="Product IMEHJ",
                     SupplierId= 1,
                     UnitPrice = 10,
                 },
                 new Product()
                 {
                     ProductId= 3,
                     CategoryId= 2,
                     Discontinued=false,
                     Name="Product IMEHJ",
                     SupplierId=1,
                     UnitPrice =19,
                 },
            };
        }
        public void Add(Product entity)
        {
            if (Exists(pro => pro.Name.Equals(entity.Name, StringComparison.OrdinalIgnoreCase)))
                throw new ProductException("Product exists...");

            if (Entities != null && Entities.Any())
            {
                var productId = Entities.Max(pro => pro.ProductId);
                entity.ProductId = productId + 1;
            }
            else
                entity.ProductId = 1;


            Entities.Add(entity);

        }
        public IEnumerable<Product> GetAll() => this.Entities;
        public Product GetById(int entityId) => this.Entities.SingleOrDefault(pro => pro.ProductId == entityId);
        public void Remove(int entityId)
        {
            Product product = GetById(entityId);
            this.Entities.Remove(product);
        }
        public void Update(Product entity)
        {
            var produtToUpdate = GetById(entity.ProductId);

            if (produtToUpdate != null)
            {
                produtToUpdate.Name = entity.Name;
                produtToUpdate.CategoryId = entity.CategoryId;
                produtToUpdate.Discontinued = entity.Discontinued;
                produtToUpdate.SupplierId = entity.SupplierId;
                produtToUpdate.UnitPrice = entity.UnitPrice;
               
            }
        }
        public bool Exists(Func<Product, bool> predicate)
        {
            return Entities.Any(predicate);
        }

        public IEnumerable<Product> GetProductByCategoryId(int categoryId)
        {
            return this.Entities.Where(ca => ca.CategoryId == categoryId);
        }
    }
}
