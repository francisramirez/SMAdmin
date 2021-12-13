using System.Linq;
using System.Collections.Generic;
using Xunit;
using CoreBusiness.Entities;
using UseCases.Contracts;
using UseCases.ViewUsesCasesModels.Categories;
using Moq;
namespace SMTest
{
    public class ViewCategoriesUseCasesTests
    {
        private readonly ViewCategoriesUseCases viewCategoriesUseCases;
        private readonly Mock<ICategoryRepository> _categoryRepMock = new();
        public ViewCategoriesUseCasesTests() => this.viewCategoriesUseCases = new ViewCategoriesUseCases(_categoryRepMock.Object);

        [Fact]
        public void GetCategories_ShouldReturnCategories()
        {
            //Arrange
            List<Category> expectCategories = new List<Category>()
            {
                new Category()
                {
                    CategoryId = 1,
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


            _categoryRepMock.Setup(x => x.GetAll())
                            .Returns(expectCategories);

            //Act
            var custumers = viewCategoriesUseCases.Execute();


            //Assert
            Assert.Equal(custumers.First().CategoryId, expectCategories.First().CategoryId);
        }
    }
}
