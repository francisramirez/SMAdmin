using CoreBusiness.Entities;
using System.Collections.Generic;

namespace UseCases.Contracts
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
        public void AddCategory(Category category);
        public void UpdateCategory(Category category);

        public void RemoveCategory(int categoryId);
        public Category GetCategoryById(int categoryId);
    }
}
