using System;
using System.Linq;
using CoreBusiness.Entities;
using System.Collections.Generic;
using UseCases.Contracts;
using UseCases.Exceptions;


namespace DataInMemory.Repositories
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {

        public List<Category> Entities { get; set; }

        public CategoryInMemoryRepository()
        {
            Entities = new List<Category>()
            {
                new Category()
                {
                    CategoryId=1,
                    Name= "Beverages",
                    Description= "Soft drinks, coffees, teas, beers, and ales"
                },
                new Category()
                {
                     CategoryId=2,
                    Description="Sweet and savory sauces, relishes, spreads, and seasonings",
                    Name="Condiments"
                },
                new Category()
                {
                    CategoryId=3,
                    Name ="Dairy Products",
                    Description="Cheeses"
                }
            };
        }
        public IEnumerable<Category> GetAll() => this.Entities;

        public void Add(Category entity)
        {
            if (Entities.Any(ca => ca.Name.Equals(entity.Name, System.StringComparison.OrdinalIgnoreCase)))
                throw new CategoryException("Category Exists...");

            if (Entities != null && Entities.Count > 0)
            {
                var maxCategoryId = Entities.Max(ca => ca.CategoryId) + 1;
                entity.CategoryId = maxCategoryId;
            }
            else
                entity.CategoryId = 1;


            Entities.Add(entity);

        }

        public void Update(Category entity)
        {
            var categoryToUpdate = GetById(entity.CategoryId);

            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = entity.Name;
                categoryToUpdate.Description = entity.Description;
            }
        }

        public void Remove(int entityId)
        {
            Category removeCategory = GetById(entityId);
            Entities?.Remove(removeCategory);
        }

        public Category GetById(int entityId) => Entities?.SingleOrDefault(ca => ca.CategoryId == entityId);

        public bool Exists(Func<Category, bool> predicate) => Entities.Any(predicate);
    }
}
