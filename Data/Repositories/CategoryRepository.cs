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
        private List<Category> categories;
        public CategoryInMemoryRepository()
        {
            categories = new List<Category>()
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

        public void AddCategory(Category category)
        {
            if (categories.Any(ca => ca.Name.Equals(category.Name, System.StringComparison.OrdinalIgnoreCase)))
                throw new CategoryException("Category Exists...");

            if (categories != null && categories.Count > 0)
            {
                var maxCategoryId = categories.Max(ca => ca.CategoryId) + 1;
                category.CategoryId = maxCategoryId;
            }
            else
                category.CategoryId = 1;


            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);

            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }


        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(ca => ca.CategoryId == categoryId);
        }

        public void RemoveCategory(int categoryId)
        {
            Category removeCategory = GetCategoryById(categoryId);
            categories?.Remove(removeCategory);
        }
    }
}
