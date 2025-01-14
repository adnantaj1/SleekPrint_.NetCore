using Microsoft.AspNetCore.Mvc;
using Moq;
using SleekPrint.Areas.Admin.Controllers;
using SleekPrint.DataAccess.Repository.IRepository;
using SleekPrint.Models;
using System.Collections.Generic;
using Xunit;

namespace SleekPrintTests.Controllers
{
    public class CategoryControllerTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<ICategoryRepository> _mockCategoryRepository;
        private readonly CategoryController _categoryController;

        public CategoryControllerTests()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockCategoryRepository = new Mock<ICategoryRepository>();

            _mockUnitOfWork.Setup(uow => uow.Category).Returns(_mockCategoryRepository.Object);

            _categoryController = new CategoryController(_mockUnitOfWork.Object);
        }

        [Fact]
        public void Index_ReturnsViewResult_WithCategoryList()
        {
            // Arrange
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "Category1" },
                new Category { Id = 2, Name = "Category2" }
            };

            _mockCategoryRepository
                .Setup(repo => repo.GetAll(It.IsAny<System.Linq.Expressions.Expression<System.Func<Category, bool>>>(), It.IsAny<string>()))
                .Returns(categories);


            // Act
            var result = _categoryController.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<Category>>(viewResult.Model);
            Assert.Equal(2, model.Count);
            _mockCategoryRepository.Verify(repo => repo.GetAll(null, null), Times.Once);
        }

    }
}
